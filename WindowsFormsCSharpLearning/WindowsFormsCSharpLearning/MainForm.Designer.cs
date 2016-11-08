using System.Windows.Forms;

namespace WindowsFormsCSharpLearning
{
    partial class MainForm
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.XPathQueryResultTextBox = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FullXMLBox = new System.Windows.Forms.RichTextBox();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.BrowseFileButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ErrorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.xPath = new System.Windows.Forms.TextBox();
            this.ApplyXPath = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.AttributeNameComboBox = new System.Windows.Forms.ComboBox();
            this.AttributeConditionComboBox = new System.Windows.Forms.ComboBox();
            this.AttributeValueTextBox = new System.Windows.Forms.TextBox();
            this.SearchNodeTextBox = new System.Windows.Forms.TextBox();
            this.NodeNameComboBox = new System.Windows.Forms.ComboBox();
            this.SearchNodeConditionTextComboBox = new System.Windows.Forms.ComboBox();
            this.NodeNameAttrComboBox = new System.Windows.Forms.ComboBox();
            this.TextSearchXPathButton = new System.Windows.Forms.Button();
            this.AttributeSelectXPathButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ResetAllButton = new System.Windows.Forms.Button();
            this.StatusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 854);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(1474, 25);
            this.StatusStrip1.TabIndex = 1;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(49, 20);
            this.ToolStripStatusLabel1.Text = "Status";
            this.ToolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.XPathQueryResultTextBox);
            this.panel1.Location = new System.Drawing.Point(832, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 272);
            this.panel1.TabIndex = 2;
            // 
            // XPathQueryResultTextBox
            // 
            this.XPathQueryResultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XPathQueryResultTextBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.XPathQueryResultTextBox.Location = new System.Drawing.Point(0, 0);
            this.XPathQueryResultTextBox.Name = "XPathQueryResultTextBox";
            this.XPathQueryResultTextBox.Size = new System.Drawing.Size(615, 272);
            this.XPathQueryResultTextBox.TabIndex = 0;
            this.XPathQueryResultTextBox.Text = "";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.FullXMLBox);
            this.panel2.Location = new System.Drawing.Point(6, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 584);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // FullXMLBox
            // 
            this.FullXMLBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FullXMLBox.Location = new System.Drawing.Point(0, 0);
            this.FullXMLBox.Name = "FullXMLBox";
            this.FullXMLBox.Size = new System.Drawing.Size(677, 584);
            this.FullXMLBox.TabIndex = 0;
            this.FullXMLBox.Text = "";
            this.FullXMLBox.TextChanged += new System.EventHandler(this.FullXMLBox_TextChanged);
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.AcceptsReturn = true;
            this.FileNameTextBox.AcceptsTab = true;
            this.FileNameTextBox.AllowDrop = true;
            this.FileNameTextBox.Location = new System.Drawing.Point(18, 53);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(218, 22);
            this.FileNameTextBox.TabIndex = 4;
            this.FileNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.FileNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fileNameText_KeyDown);
            // 
            // BrowseFileButton
            // 
            this.BrowseFileButton.Location = new System.Drawing.Point(242, 52);
            this.BrowseFileButton.Name = "BrowseFileButton";
            this.BrowseFileButton.Size = new System.Drawing.Size(177, 23);
            this.BrowseFileButton.TabIndex = 5;
            this.BrowseFileButton.Text = "Browse File";
            this.BrowseFileButton.UseVisualStyleBackColor = true;
            this.BrowseFileButton.Click += new System.EventHandler(this.BrowseButtonClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(12, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1450, 628);
            this.panel3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(844, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Error Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(832, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "XPath Examples";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(838, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "XPath Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input XML";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ErrorRichTextBox);
            this.panel5.Location = new System.Drawing.Point(832, 508);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(615, 117);
            this.panel5.TabIndex = 5;
            // 
            // ErrorRichTextBox
            // 
            this.ErrorRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorRichTextBox.ForeColor = System.Drawing.Color.Red;
            this.ErrorRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.ErrorRichTextBox.Name = "ErrorRichTextBox";
            this.ErrorRichTextBox.Size = new System.Drawing.Size(615, 117);
            this.ErrorRichTextBox.TabIndex = 0;
            this.ErrorRichTextBox.Text = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listBox1);
            this.panel4.Location = new System.Drawing.Point(832, 362);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(615, 107);
            this.panel4.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(615, 100);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // xPath
            // 
            this.xPath.Location = new System.Drawing.Point(820, 187);
            this.xPath.Name = "xPath";
            this.xPath.Size = new System.Drawing.Size(483, 22);
            this.xPath.TabIndex = 7;
            this.xPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fileNameText_KeyDown);
            // 
            // ApplyXPath
            // 
            this.ApplyXPath.Location = new System.Drawing.Point(1329, 181);
            this.ApplyXPath.Margin = new System.Windows.Forms.Padding(0);
            this.ApplyXPath.Name = "ApplyXPath";
            this.ApplyXPath.Size = new System.Drawing.Size(115, 28);
            this.ApplyXPath.TabIndex = 8;
            this.ApplyXPath.Text = "Apply";
            this.ApplyXPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ApplyXPath.UseCompatibleTextRendering = true;
            this.ApplyXPath.UseVisualStyleBackColor = true;
            this.ApplyXPath.Click += new System.EventHandler(this.applyButtonClick);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SubmitButton.Location = new System.Drawing.Point(242, 113);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(177, 29);
            this.SubmitButton.TabIndex = 9;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // AttributeNameComboBox
            // 
            this.AttributeNameComboBox.FormattingEnabled = true;
            this.AttributeNameComboBox.Items.AddRange(new object[] {
            "id"});
            this.AttributeNameComboBox.Location = new System.Drawing.Point(758, 111);
            this.AttributeNameComboBox.Name = "AttributeNameComboBox";
            this.AttributeNameComboBox.Size = new System.Drawing.Size(121, 24);
            this.AttributeNameComboBox.TabIndex = 10;
            // 
            // AttributeConditionComboBox
            // 
            this.AttributeConditionComboBox.FormattingEnabled = true;
            this.AttributeConditionComboBox.Items.AddRange(new object[] {
            "equals"});
            this.AttributeConditionComboBox.Location = new System.Drawing.Point(917, 111);
            this.AttributeConditionComboBox.Name = "AttributeConditionComboBox";
            this.AttributeConditionComboBox.Size = new System.Drawing.Size(121, 24);
            this.AttributeConditionComboBox.TabIndex = 11;
            // 
            // AttributeValueTextBox
            // 
            this.AttributeValueTextBox.Location = new System.Drawing.Point(1070, 111);
            this.AttributeValueTextBox.Name = "AttributeValueTextBox";
            this.AttributeValueTextBox.Size = new System.Drawing.Size(233, 22);
            this.AttributeValueTextBox.TabIndex = 12;
            // 
            // SearchNodeTextBox
            // 
            this.SearchNodeTextBox.Location = new System.Drawing.Point(917, 45);
            this.SearchNodeTextBox.Name = "SearchNodeTextBox";
            this.SearchNodeTextBox.Size = new System.Drawing.Size(386, 22);
            this.SearchNodeTextBox.TabIndex = 13;
            this.SearchNodeTextBox.TextChanged += new System.EventHandler(this.SearchNodeTextBox_TextChanged);
            // 
            // NodeNameComboBox
            // 
            this.NodeNameComboBox.FormattingEnabled = true;
            this.NodeNameComboBox.Location = new System.Drawing.Point(604, 47);
            this.NodeNameComboBox.Name = "NodeNameComboBox";
            this.NodeNameComboBox.Size = new System.Drawing.Size(121, 24);
            this.NodeNameComboBox.TabIndex = 14;
            // 
            // SearchNodeConditionTextComboBox
            // 
            this.SearchNodeConditionTextComboBox.FormattingEnabled = true;
            this.SearchNodeConditionTextComboBox.Items.AddRange(new object[] {
            "contains",
            "starts-with(select parent)",
            "starts-with(self)"});
            this.SearchNodeConditionTextComboBox.Location = new System.Drawing.Point(758, 45);
            this.SearchNodeConditionTextComboBox.Name = "SearchNodeConditionTextComboBox";
            this.SearchNodeConditionTextComboBox.Size = new System.Drawing.Size(121, 24);
            this.SearchNodeConditionTextComboBox.TabIndex = 15;
            // 
            // NodeNameAttrComboBox
            // 
            this.NodeNameAttrComboBox.FormattingEnabled = true;
            this.NodeNameAttrComboBox.Location = new System.Drawing.Point(604, 109);
            this.NodeNameAttrComboBox.Name = "NodeNameAttrComboBox";
            this.NodeNameAttrComboBox.Size = new System.Drawing.Size(121, 24);
            this.NodeNameAttrComboBox.TabIndex = 16;
            // 
            // TextSearchXPathButton
            // 
            this.TextSearchXPathButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextSearchXPathButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TextSearchXPathButton.Location = new System.Drawing.Point(1359, 47);
            this.TextSearchXPathButton.Name = "TextSearchXPathButton";
            this.TextSearchXPathButton.Size = new System.Drawing.Size(75, 23);
            this.TextSearchXPathButton.TabIndex = 17;
            this.TextSearchXPathButton.Text = "XPath";
            this.TextSearchXPathButton.UseVisualStyleBackColor = false;
            this.TextSearchXPathButton.Click += new System.EventHandler(this.TextSearchXPathButtonClick);
            // 
            // AttributeSelectXPathButton
            // 
            this.AttributeSelectXPathButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AttributeSelectXPathButton.Location = new System.Drawing.Point(1359, 109);
            this.AttributeSelectXPathButton.Name = "AttributeSelectXPathButton";
            this.AttributeSelectXPathButton.Size = new System.Drawing.Size(75, 23);
            this.AttributeSelectXPathButton.TabIndex = 18;
            this.AttributeSelectXPathButton.Text = "XPath";
            this.AttributeSelectXPathButton.UseVisualStyleBackColor = false;
            this.AttributeSelectXPathButton.Click += new System.EventHandler(this.AttributeSelectXPathButtonClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Node Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(758, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Condition";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(917, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Search Text";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(604, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Node Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(758, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Attribute";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(917, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Condition";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1079, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Attribute Value";
            // 
            // ResetAllButton
            // 
            this.ResetAllButton.Location = new System.Drawing.Point(50, 118);
            this.ResetAllButton.Name = "ResetAllButton";
            this.ResetAllButton.Size = new System.Drawing.Size(152, 23);
            this.ResetAllButton.TabIndex = 26;
            this.ResetAllButton.Text = "Reset All";
            this.ResetAllButton.UseVisualStyleBackColor = true;
            this.ResetAllButton.Click += new System.EventHandler(this.ResetAllButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1474, 879);
            this.Controls.Add(this.ResetAllButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AttributeSelectXPathButton);
            this.Controls.Add(this.TextSearchXPathButton);
            this.Controls.Add(this.NodeNameAttrComboBox);
            this.Controls.Add(this.SearchNodeConditionTextComboBox);
            this.Controls.Add(this.NodeNameComboBox);
            this.Controls.Add(this.SearchNodeTextBox);
            this.Controls.Add(this.AttributeValueTextBox);
            this.Controls.Add(this.AttributeConditionComboBox);
            this.Controls.Add(this.AttributeNameComboBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ApplyXPath);
            this.Controls.Add(this.xPath);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BrowseFileButton);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.StatusStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox XPathQueryResultTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button BrowseFileButton;
        private System.Windows.Forms.RichTextBox FullXMLBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox xPath;
        private System.Windows.Forms.Button ApplyXPath;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        private System.Windows.Forms.Button SubmitButton;
        private Panel panel5;
        private RichTextBox ErrorRichTextBox;
        private Panel panel4;
        private ListBox listBox1;
        private ComboBox AttributeNameComboBox;
        private ComboBox AttributeConditionComboBox;
        private TextBox AttributeValueTextBox;
        private TextBox SearchNodeTextBox;
        private ComboBox NodeNameComboBox;
        private ComboBox SearchNodeConditionTextComboBox;
        private ComboBox NodeNameAttrComboBox;
        private Button TextSearchXPathButton;
        private Button AttributeSelectXPathButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button ResetAllButton;
    }
}