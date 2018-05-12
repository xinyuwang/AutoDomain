using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoDomain.analyzer;

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
                pbQuery.Value = value;
            }
        }





        public Mainform()
        {
            InitializeComponent();
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


        private void btnQuery_Click(object sender, EventArgs e)
        {
            //get keywords
            List<string> arKeywords = new List<string>();

            for (int i = 0; i < rtbKeywords.Lines.Count(); i++)
            {
                arKeywords.AddRange(rtbKeywords.Lines[i].Split(' '));
            }

            //get paddingwords
            List<string> arPadding = new List<string>();

            for (int i = 0; i < rtbKeywords.Lines.Count(); i++)
            {
                arKeywords.AddRange(rtbKeywords.Lines[i].Split(' '));
            }




        }
    }
}
