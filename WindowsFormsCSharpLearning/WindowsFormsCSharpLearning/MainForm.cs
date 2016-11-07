using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace WindowsFormsCSharpLearning
{
    public partial class MainForm : Form
    {
        public string XmlText { get; set; }
        public string FileName { get; set; }


        public MainForm()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private bool validFileName(string fileName)
        {
            return File.Exists(fileName) && (fileName.ToUpper().EndsWith(".XML")
                            || fileName.ToUpper().EndsWith(".TXT"));
        }

        private void BrowseButtonClick(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string fileName = openFileDialog1.FileName;
                try
                {
                    if (validFileName(fileName))
                    {
                        this.FileName = fileName;
                        FileNameTextBox.Text = fileName;
                    }
                    else
                    {
                        MessageBox.Show("Please Select Files Having XML and TXT Extensions Only",
                            "Invalid input file",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    
                }
                catch (IOException ex)
                {
                    showStatusError(ex.Message);
                }
            }
            Console.WriteLine(result); // <-- For debugging use.
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void applyButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (!validXml())
                {
                    MessageBox.Show("XML Input is not well formed");
                }
                else
                {
                    string xpath = this.xPath.Text;
                    if (xpath == null || xpath == "")
                    {
                        return;
                    }
                    else
                    {
                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(this.XmlText);

                        XmlNodeList nodes = doc.DocumentElement.SelectNodes(xpath);
                        XPathQueryResultTextBox.ResetText();
                        XPathQueryResultTextBox.AppendText(XmlNodeListToString(nodes));

                        resetStatusStrip();
                    }
                }
            }
            catch (Exception ex)
            {
                showStatusError(ex.Message);
            }
        }



        private string XmlNodeListToString(XmlNodeList nodeList)
        {
            String returnStr = "";
            if (nodeList != null)
            {
                foreach (XmlNode node in nodeList)
                {
                    returnStr += Environment.NewLine;
                    returnStr += node.OuterXml;
                }

            }

            //return returnStr;
            //return FormatXml(returnStr);
            return FormatXml("<root>" + returnStr + "</root>");
        }


        private string FormatXml(string xml)
        {
            try
            {
                //XDocument doc = XDocument.Parse(xml);
                XElement.Parse(xml).Save(@"D:\\doc.xml");
                string formattedXml = File.ReadAllText(@"D:\\doc.xml");
                Console.WriteLine(formattedXml);
                return formattedXml;
            }
            catch (Exception)
            {
                return xml;
            }
        }

        private bool validXml()
        {
            if (this.XmlText == null || this.XmlText == "")
            {
                return false;
            }           

            try
            {
                XmlReader xr = XmlReader.Create(
                new StringReader(this.XmlText));

                while (xr.Read()) { }
                Console.WriteLine("XML Validation Success: " + true);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("XML Validation Failed : " + ex.Message);
                return false;
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileNameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitButton_Click(this, new EventArgs());
            }
        }

        private void xPath_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
            {
                applyButtonClick(this, new EventArgs());
            }*/
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void FullXMLBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {

                string text = "";
                if (this.FileName != null || this.FileName != "")
                {
                    text = File.ReadAllText(this.FileName);
                }
                else
                {
                    string fileName = FileNameTextBox.Text;
                    if (validFileName(fileName))
                    {

                    }
                    else
                    {
                        text = File.ReadAllText(fileName);
                    }
                }

                int size = -1;

                this.XmlText = text;
                size = text.Length;
                FullXMLBox.ResetText();
                FullXMLBox.AppendText(text);
                XPathQueryResultTextBox.ResetText();
                XPathQueryResultTextBox.AppendText(text);

                XPathDocument myXPathDoc = new XPathDocument(this.FileName);
                XslCompiledTransform myXslTrans = new XslCompiledTransform();
                myXslTrans.Load("..\\..\\XPathGenerator.xslt");
                XmlTextWriter myWriter = new XmlTextWriter("D:\\result.html", null);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(this.XmlText);
                XmlReader xmlReadB = new XmlTextReader(new StringReader(doc.DocumentElement.OuterXml));
                myXslTrans.Transform(xmlReadB, null, myWriter);

                resetStatusStrip();
            }
            catch(Exception ex)
            {
                showStatusError(ex.Message);
            }            
        }

        private void showStatusError(string message)
        {
            ToolStripStatusLabel1.Text = "Exception: " + message;
            ToolStripStatusLabel1.ForeColor = Color.Red;
            StatusStrip1.Refresh();
            MessageBox.Show("Exception: " + message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void resetStatusStrip()
        {
            ToolStripStatusLabel1.Text = "";
            ToolStripStatusLabel1.ForeColor = Color.Black;
            StatusStrip1.Refresh();
        }

        
    }
}
