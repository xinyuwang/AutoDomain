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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtbKeywords = new System.Windows.Forms.RichTextBox();
            this.rtbPaddingwords = new System.Windows.Forms.RichTextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.gbKeywords = new System.Windows.Forms.GroupBox();
            this.gbPaddingwords = new System.Windows.Forms.GroupBox();
            this.pbQuery = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbDomains = new System.Windows.Forms.GroupBox();
            this.cbAllDomains = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbKeywords.SuspendLayout();
            this.gbPaddingwords.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbDomains.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1792, 1286);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbDomains);
            this.tabPage1.Controls.Add(this.pbQuery);
            this.tabPage1.Controls.Add(this.gbPaddingwords);
            this.tabPage1.Controls.Add(this.gbKeywords);
            this.tabPage1.Controls.Add(this.btnQuery);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1784, 1244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "  QueryPanel  ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(1784, 1244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "  ResultPanel  ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtbKeywords
            // 
            this.rtbKeywords.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbKeywords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbKeywords.Location = new System.Drawing.Point(31, 56);
            this.rtbKeywords.Name = "rtbKeywords";
            this.rtbKeywords.Size = new System.Drawing.Size(1191, 345);
            this.rtbKeywords.TabIndex = 3;
            this.rtbKeywords.Text = "";
            // 
            // rtbPaddingwords
            // 
            this.rtbPaddingwords.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbPaddingwords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbPaddingwords.Location = new System.Drawing.Point(31, 68);
            this.rtbPaddingwords.Name = "rtbPaddingwords";
            this.rtbPaddingwords.Size = new System.Drawing.Size(1191, 417);
            this.rtbPaddingwords.TabIndex = 5;
            this.rtbPaddingwords.Text = "";
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.Location = new System.Drawing.Point(56, 1116);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(142, 59);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // gbKeywords
            // 
            this.gbKeywords.Controls.Add(this.rtbKeywords);
            this.gbKeywords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKeywords.Location = new System.Drawing.Point(25, 23);
            this.gbKeywords.Name = "gbKeywords";
            this.gbKeywords.Size = new System.Drawing.Size(1248, 432);
            this.gbKeywords.TabIndex = 7;
            this.gbKeywords.TabStop = false;
            this.gbKeywords.Text = "Keywords";
            // 
            // gbPaddingwords
            // 
            this.gbPaddingwords.Controls.Add(this.label1);
            this.gbPaddingwords.Controls.Add(this.rtbPaddingwords);
            this.gbPaddingwords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.gbPaddingwords.Location = new System.Drawing.Point(25, 479);
            this.gbPaddingwords.Name = "gbPaddingwords";
            this.gbPaddingwords.Size = new System.Drawing.Size(1248, 594);
            this.gbPaddingwords.TabIndex = 8;
            this.gbPaddingwords.TabStop = false;
            this.gbPaddingwords.Text = "Padding Words";
            // 
            // pbQuery
            // 
            this.pbQuery.Location = new System.Drawing.Point(228, 1116);
            this.pbQuery.Name = "pbQuery";
            this.pbQuery.Size = new System.Drawing.Size(1501, 59);
            this.pbQuery.TabIndex = 9;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1256);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1792, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 25);
            this.toolStripStatusLabel1.Text = "State:";
            // 
            // gbDomains
            // 
            this.gbDomains.Controls.Add(this.checkedListBox1);
            this.gbDomains.Controls.Add(this.cbAllDomains);
            this.gbDomains.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.gbDomains.Location = new System.Drawing.Point(1307, 23);
            this.gbDomains.Name = "gbDomains";
            this.gbDomains.Size = new System.Drawing.Size(450, 1050);
            this.gbDomains.TabIndex = 10;
            this.gbDomains.TabStop = false;
            this.gbDomains.Text = "Domains";
            // 
            // cbAllDomains
            // 
            this.cbAllDomains.AutoSize = true;
            this.cbAllDomains.Location = new System.Drawing.Point(33, 978);
            this.cbAllDomains.Name = "cbAllDomains";
            this.cbAllDomains.Size = new System.Drawing.Size(291, 36);
            this.cbAllDomains.TabIndex = 6;
            this.cbAllDomains.Text = "All support domains";
            this.cbAllDomains.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1029, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Support basic RegEx, e.g. [0~9]{3};  [G500] => Google Top 500 frequency words;";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            ".co",
            ".vip",
            ".net.cn",
            ".org.cn",
            ".media",
            ".club",
            ".ca",
            ".today",
            ".life",
            ".com",
            ".shop",
            ".world",
            ".com.cn",
            ".global",
            ".dance",
            ".company",
            ".city",
            ".buzz",
            ".studio",
            ".cash"});
            this.checkedListBox1.Location = new System.Drawing.Point(33, 56);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(389, 897);
            this.checkedListBox1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1778, 1238);
            this.dataGridView1.TabIndex = 0;
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
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1792, 1286);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoDomain";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gbKeywords.ResumeLayout(false);
            this.gbPaddingwords.ResumeLayout(false);
            this.gbPaddingwords.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbDomains.ResumeLayout(false);
            this.gbDomains.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox gbDomains;
        private System.Windows.Forms.CheckBox cbAllDomains;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

