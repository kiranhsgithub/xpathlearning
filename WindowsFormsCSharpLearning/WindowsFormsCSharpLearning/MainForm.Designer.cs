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
            this.panel5 = new System.Windows.Forms.Panel();
            this.ErrorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.xPath = new System.Windows.Forms.TextBox();
            this.ApplyXPath = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(832, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 251);
            this.panel1.TabIndex = 2;
            // 
            // XPathQueryResultTextBox
            // 
            this.XPathQueryResultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XPathQueryResultTextBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.XPathQueryResultTextBox.Location = new System.Drawing.Point(0, 0);
            this.XPathQueryResultTextBox.Name = "XPathQueryResultTextBox";
            this.XPathQueryResultTextBox.Size = new System.Drawing.Size(615, 251);
            this.XPathQueryResultTextBox.TabIndex = 0;
            this.XPathQueryResultTextBox.Text = "";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.FullXMLBox);
            this.panel2.Location = new System.Drawing.Point(6, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 616);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // FullXMLBox
            // 
            this.FullXMLBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FullXMLBox.Location = new System.Drawing.Point(0, 0);
            this.FullXMLBox.Name = "FullXMLBox";
            this.FullXMLBox.Size = new System.Drawing.Size(671, 616);
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
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(12, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1450, 628);
            this.panel3.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ErrorRichTextBox);
            this.panel5.Location = new System.Drawing.Point(832, 425);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(615, 200);
            this.panel5.TabIndex = 5;
            // 
            // ErrorRichTextBox
            // 
            this.ErrorRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorRichTextBox.ForeColor = System.Drawing.Color.Red;
            this.ErrorRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.ErrorRichTextBox.Name = "ErrorRichTextBox";
            this.ErrorRichTextBox.Size = new System.Drawing.Size(615, 200);
            this.ErrorRichTextBox.TabIndex = 0;
            this.ErrorRichTextBox.Text = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listBox1);
            this.panel4.Location = new System.Drawing.Point(832, 266);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(615, 153);
            this.panel4.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(609, 132);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 879);
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
    }
}