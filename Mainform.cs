using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoDomain.analyzer;
using System.IO;

namespace AutoDomain
{
    public partial class Mainform : Form
    {

        /// <summary>
        /// QueryProgress from 0 to 100
        /// </summary>
        public int QueryProgress
        {
            get
            {
                return pbQuery.Value;
            }
            set
            {
                SetProgressCallback setProgressCallback = new SetProgressCallback(SetProgress);
                pbQuery.Invoke(setProgressCallback, new Object[] { value });
            }
        }

        public bool QueryButtonEnabled
        {
            get
            {
                return btnQuery.Enabled;
            }
            set
            {
                SetQueryButtonEnableCallback setQueryButtonEnableCallback = SetQueryButtonEnable;
                btnQuery.Invoke(setQueryButtonEnableCallback, new Object[] { value });
            }
        }

        #region Delegate Update

        delegate void SetProgressCallback(int iVal);
        delegate void ClearAllDomainCallback();
        delegate void AddDomainCallback(DomainInfo domainInfo);
        delegate void SetQueryButtonEnableCallback(bool state);
        delegate void SetStatusStripCallback(int iAll, int iCur, int iAvailable);
        delegate void ShowAnalyseExceptionCallback(AnalyseException analyseException);

        #endregion

        private void ShowAnalyseException(AnalyseException analyseException)
        {
            MessageBox.Show(analyseException.Message, "Analyse Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SetProgress(int iVal)
        {
            pbQuery.Value = iVal;
            tspbQuery.Value = iVal;
        }

        private void ClearAllDomain()
        {
            dgvResultView.Rows.Clear();
        }

        private void AddDomain(DomainInfo domainInfo)
        {
            dgvResultView.Rows.Add(new string[] { domainInfo.URL, domainInfo.Price.ToString() });
        }

        private void SetQueryButtonEnable(bool state)
        {
            btnQuery.Enabled = state;
        }

        private void SetStatusStrip(int iAll, int iCur, int iAvailable)
        {
            staProgress.Text = String.Format("AllCount : {0}  ProcessedNum : {1}  AvailableNum : {2}", iAll, iCur, iAvailable);
            tsPercent.Text = String.Format("{0}%", iCur * 100 / iAll);
        }


        public Mainform()
        {
            InitializeComponent();
            //Only read data
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }


        private List<String> analyzePadding(List<string> arPadding)
        {
            List<string> ret = arPadding;

            IAnalyse[] arIAnalyse = new IAnalyse[] { new BasicRegexAnalyzer(), new GoogleTopWordsAnalyzer() };

            foreach (IAnalyse iAnalyse in arIAnalyse)
            {
                iAnalyse.init();
                ret = iAnalyse.analyse(ret);
            }

            return ret;

        }

        void ThreadProc(Object stateInfo)
        {
            try
            {

                QueryButtonEnabled = false;
                QueryProgress = 0;

                //get keywords
                List<string> arKeywords = new List<string>();

                for (int i = 0; i < rtbKeywords.Lines.Count(); i++)
                {
                    arKeywords.AddRange(rtbKeywords.Lines[i].Split(' '));
                }

                //get paddingwords
                List<string> arPadding = new List<string>();

                for (int i = 0; i < rtbPaddingwords.Lines.Count(); i++)
                {
                    arPadding.AddRange(rtbPaddingwords.Lines[i].Split(' '));
                }

                //process padding words
                arPadding = analyzePadding(arPadding);

                List<string> arDomains = new List<string>();
                if (arKeywords.Count == 0)
                {
                    //If no keywords
                    arDomains = arPadding;
                }
                else
                {
                    foreach (string strKeyword in arKeywords)
                    {
                        foreach (string strPadding in arPadding)
                        {
                            arDomains.Add(strPadding.Replace("$", strKeyword));
                        }
                    }
                }

                //get all extension
                List<string> arExtension = new List<string>();
                for (int i = 0; i < clbDomainExtension.Items.Count; i++)
                {
                    if (clbDomainExtension.GetItemChecked(i))
                    {
                        arExtension.Add(clbDomainExtension.GetItemText(clbDomainExtension.Items[i]));
                    }
                }

                //get all full domain name
                List<string> arDomainName = new List<string>();
                foreach (string strExtension in arExtension)
                {
                    foreach (string strDomain in arDomains)
                    {
                        arDomainName.Add(strDomain + strExtension);
                    }
                }

                //Query to Godaddy
                List<DomainInfo> arDomainInfo = new List<DomainInfo>();
                int iCount = 0, iAvailable = 0;
                foreach (string strURL in arDomainName)
                {
                    DomainInfo domainInfo = GodaddyDelegation.CheckDomain(strURL);

                    //update to progress
                    iCount++;
                    QueryProgress = iCount * 100 / arDomainName.Count;

                    if (domainInfo != null)
                    {
                        arDomainInfo.Add(domainInfo);
                        iAvailable++;

                        //Render to ListView
                        AddDomainCallback addDomainCallback = AddDomain;
                        dgvResultView.Invoke(addDomainCallback, new Object[] { domainInfo });

                    }

                    //update status
                    SetStatusStripCallback setStatusStripCallback = new SetStatusStripCallback(SetStatusStrip);
                    statusBar.Invoke(setStatusStripCallback, new Object[] { arDomainName.Count, iCount, iAvailable });


                }

                QueryButtonEnabled = true;

            }
            catch (AnalyseException analyseException)
            {
                ShowAnalyseExceptionCallback showAnalyseExceptionCallback = new ShowAnalyseExceptionCallback(ShowAnalyseException);
                this.Invoke(showAnalyseExceptionCallback, new Object[] { analyseException });
                QueryButtonEnabled = true;
                QueryProgress = 0;
            }

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadProc));
        }

        private void cbAllDomains_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clbDomainExtension.Items.Count; i++)
            {
                clbDomainExtension.SetItemChecked(i, cbAllDomains.Checked);
            }

        }

        private void rightMenuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ".txt|.txt";
            saveFileDialog.FileOk += SaveFileDialog_FileOk;
            saveFileDialog.ShowDialog();
        }

        private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            SaveFileDialog saveFileDialog = (SaveFileDialog)sender;

            List<string> arLines = new List<string>();
            for (int i = 0; i < dgvResultView.Rows.Count; i++)
            {
                arLines.Add(dgvResultView.Rows[i].Cells[0].Value.ToString() + " " + dgvResultView.Rows[i].Cells[1].Value.ToString());
            }

            File.WriteAllLines(saveFileDialog.FileName, arLines);
        }
    }
}
