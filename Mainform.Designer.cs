namespace AutoDomain
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbDomains = new System.Windows.Forms.GroupBox();
            this.clbDomainExtension = new System.Windows.Forms.CheckedListBox();
            this.cbAllDomains = new System.Windows.Forms.CheckBox();
            this.pbQuery = new System.Windows.Forms.ProgressBar();
            this.gbPaddingwords = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbPaddingwords = new System.Windows.Forms.RichTextBox();
            this.gbKeywords = new System.Windows.Forms.GroupBox();
            this.rtbKeywords = new System.Windows.Forms.RichTextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvResultView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbQuery = new System.Windows.Forms.ToolStripProgressBar();
            this.staProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsPercent = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbDomains.SuspendLayout();
            this.gbPaddingwords.SuspendLayout();
            this.gbKeywords.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultView)).BeginInit();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1593, 1029);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbDomains);
            this.tabPage1.Controls.Add(this.pbQuery);
            this.tabPage1.Controls.Add(this.gbPaddingwords);
            this.tabPage1.Controls.Add(this.gbKeywords);
            this.tabPage1.Controls.Add(this.btnQuery);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1585, 991);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "  QueryPanel  ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbDomains
            // 
            this.gbDomains.Controls.Add(this.clbDomainExtension);
            this.gbDomains.Controls.Add(this.cbAllDomains);
            this.gbDomains.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.gbDomains.Location = new System.Drawing.Point(1162, 18);
            this.gbDomains.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDomains.Name = "gbDomains";
            this.gbDomains.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDomains.Size = new System.Drawing.Size(400, 840);
            this.gbDomains.TabIndex = 10;
            this.gbDomains.TabStop = false;
            this.gbDomains.Text = "Domains";
            // 
            // clbDomainExtension
            // 
            this.clbDomainExtension.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbDomainExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clbDomainExtension.FormattingEnabled = true;
            this.clbDomainExtension.Items.AddRange(new object[] {
            ".app",
            ".com",
            ".net",
            ".info",
            ".online",
            ".org",
            ".pro",
            ".vip",
            ".co",
            ".io",
            ".me",
            ".cc",
            ".net.cn",
            ".org.cn",
            ".club",
            ".com.cn",
            ".cloud",
            ".media",
            ".work",
            ".co.uk",
            ".store",
            ".mobi",
            ".biz",
            ".xyz",
            ".love",
            ".ltd",
            ".today",
            ".life",
            ".shop",
            ".world",
            ".app",
            ".global",
            ".dance",
            ".one",
            ".company",
            ".city",
            ".space",
            ".buzz",
            ".studio",
            ".support",
            ".design",
            ".moe",
            ".apartments",
            ".us",
            ".tv",
            ".in",
            ".com.tw",
            ".ca",
            ".jp",
            ".tw",
            ".com.au",
            ".fr",
            ".it"});
            this.clbDomainExtension.Location = new System.Drawing.Point(29, 45);
            this.clbDomainExtension.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbDomainExtension.Name = "clbDomainExtension";
            this.clbDomainExtension.Size = new System.Drawing.Size(346, 700);
            this.clbDomainExtension.TabIndex = 8;
            // 
            // cbAllDomains
            // 
            this.cbAllDomains.AutoSize = true;
            this.cbAllDomains.Location = new System.Drawing.Point(29, 782);
            this.cbAllDomains.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAllDomains.Name = "cbAllDomains";
            this.cbAllDomains.Size = new System.Drawing.Size(247, 33);
            this.cbAllDomains.TabIndex = 6;
            this.cbAllDomains.Text = "All support domains";
            this.cbAllDomains.UseVisualStyleBackColor = true;
            this.cbAllDomains.CheckedChanged += new System.EventHandler(this.cbAllDomains_CheckedChanged);
            // 
            // pbQuery
            // 
            this.pbQuery.Location = new System.Drawing.Point(203, 893);
            this.pbQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbQuery.Name = "pbQuery";
            this.pbQuery.Size = new System.Drawing.Size(1334, 47);
            this.pbQuery.TabIndex = 9;
            // 
            // gbPaddingwords
            // 
            this.gbPaddingwords.Controls.Add(this.label1);
            this.gbPaddingwords.Controls.Add(this.rtbPaddingwords);
            this.gbPaddingwords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.gbPaddingwords.Location = new System.Drawing.Point(22, 383);
            this.gbPaddingwords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPaddingwords.Name = "gbPaddingwords";
            this.gbPaddingwords.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbPaddingwords.Size = new System.Drawing.Size(1109, 475);
            this.gbPaddingwords.TabIndex = 8;
            this.gbPaddingwords.TabStop = false;
            this.gbPaddingwords.Text = "Padding Words";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1037, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Support basic RegEx, e.g. [0-9]{3};  [G500] => Google Top 500 frequency words; $ " +
    "=> keywords;";
            // 
            // rtbPaddingwords
            // 
            this.rtbPaddingwords.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbPaddingwords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbPaddingwords.Location = new System.Drawing.Point(28, 54);
            this.rtbPaddingwords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbPaddingwords.Name = "rtbPaddingwords";
            this.rtbPaddingwords.Size = new System.Drawing.Size(1059, 334);
            this.rtbPaddingwords.TabIndex = 5;
            this.rtbPaddingwords.Text = "";
            // 
            // gbKeywords
            // 
            this.gbKeywords.Controls.Add(this.rtbKeywords);
            this.gbKeywords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKeywords.Location = new System.Drawing.Point(22, 18);
            this.gbKeywords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbKeywords.Name = "gbKeywords";
            this.gbKeywords.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbKeywords.Size = new System.Drawing.Size(1109, 346);
            this.gbKeywords.TabIndex = 7;
            this.gbKeywords.TabStop = false;
            this.gbKeywords.Text = "Keywords";
            // 
            // rtbKeywords
            // 
            this.rtbKeywords.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbKeywords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbKeywords.Location = new System.Drawing.Point(28, 45);
            this.rtbKeywords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbKeywords.Name = "rtbKeywords";
            this.rtbKeywords.Size = new System.Drawing.Size(1059, 277);
            this.rtbKeywords.TabIndex = 3;
            this.rtbKeywords.Text = "";
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.Location = new System.Drawing.Point(50, 893);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(126, 47);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvResultView);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1585, 991);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "  ResultPanel  ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvResultView
            // 
            this.dgvResultView.AllowUserToAddRows = false;
            this.dgvResultView.AllowUserToDeleteRows = false;
            this.dgvResultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvResultView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultView.Location = new System.Drawing.Point(3, 2);
            this.dgvResultView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvResultView.Name = "dgvResultView";
            this.dgvResultView.ReadOnly = true;
            this.dgvResultView.RowTemplate.Height = 28;
            this.dgvResultView.Size = new System.Drawing.Size(1579, 987);
            this.dgvResultView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "DomainName";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Price";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tspbQuery,
            this.tsPercent,
            this.toolStripStatusLabel2,
            this.staProgress});
            this.statusBar.Location = new System.Drawing.Point(0, 1004);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusBar.Size = new System.Drawing.Size(1593, 25);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(132, 20);
            this.toolStripStatusLabel1.Text = "Possible Domains :";
            // 
            // tspbQuery
            // 
            this.tspbQuery.Name = "tspbQuery";
            this.tspbQuery.Size = new System.Drawing.Size(100, 19);
            // 
            // staProgress
            // 
            this.staProgress.Name = "staProgress";
            this.staProgress.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(45, 20);
            this.toolStripStatusLabel2.Text = "         ";
            // 
            // tsPercent
            // 
            this.tsPercent.Name = "tsPercent";
            this.tsPercent.Size = new System.Drawing.Size(0, 20);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 1029);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoDomain";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbDomains.ResumeLayout(false);
            this.gbDomains.PerformLayout();
            this.gbPaddingwords.ResumeLayout(false);
            this.gbPaddingwords.PerformLayout();
            this.gbKeywords.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultView)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox rtbKeywords;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbKeywords;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.RichTextBox rtbPaddingwords;
        private System.Windows.Forms.GroupBox gbPaddingwords;
        private System.Windows.Forms.ProgressBar pbQuery;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox gbDomains;
        private System.Windows.Forms.CheckBox cbAllDomains;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbDomainExtension;
        private System.Windows.Forms.DataGridView dgvResultView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ToolStripProgressBar tspbQuery;
        private System.Windows.Forms.ToolStripStatusLabel staProgress;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsPercent;
    }
}

