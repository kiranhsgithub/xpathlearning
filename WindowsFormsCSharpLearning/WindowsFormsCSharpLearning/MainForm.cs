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

namespace WindowsFormsCSharpLearning
{
    public partial class MainForm : Form
    {
        public string XmlText { get; set; }


        public MainForm()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void BrowseButtonClick(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    if (file.ToUpper().Contains("XML")
                        || file.ToUpper().Contains("TXT"))
                    {
                        string text = File.ReadAllText(file);
                        this.XmlText = text;
                        size = text.Length;                        
                        FullXMLBox.ResetText();
                        FullXMLBox.AppendText(text);
                        XPathQueryResultTextBox.ResetText();
                        XPathQueryResultTextBox.AppendText(text);
                    }
                    else
                    {
                        MessageBox.Show("Please Select Files Having XML and TXT Extensions Only");
                    }
                    
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(result); // <-- For debugging use.
        }

        private void SubmitButtonClick(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void applyButtonClick(object sender, EventArgs e)
        {
            if (!validXml())
            {
                MessageBox.Show("XML Input is not well formed");
            } else
            {
                string xpath = this.xPath.Text;
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(this.XmlText);

                XmlNodeList nodes = doc.DocumentElement.SelectNodes(xpath);
                XPathQueryResultTextBox.ResetText();
                XPathQueryResultTextBox.AppendText(XmlNodeListToString(nodes));

            }
            
        }



        private string XmlNodeListToString(XmlNodeList nodeList)
        {
            String returnStr = "";
            if (nodeList != null)
            {
                foreach (XmlNode node in nodeList)
                {
                    returnStr += node.OuterXml;
                }

            }


            return FormatXml(returnStr);
        }


        private string FormatXml(string xml)
        {
            try
            {
                XDocument doc = XDocument.Parse(xml);
                return doc.ToString();
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
    }
}
