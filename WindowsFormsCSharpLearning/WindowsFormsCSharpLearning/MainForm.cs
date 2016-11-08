﻿using System;
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

                        //XmlNodeList nodesList = doc.DocumentElement.SelectNodes(xpath);

                        XPathNavigator nav = doc.CreateNavigator();
                        XPathExpression expr = nav.Compile(xpath);
                        XPathNodeIterator nodes = nav.Select(xpath);

                        //Remove text before adding
                        XPathQueryResultTextBox.ResetText();

                        while (nodes.MoveNext())
                        {
                            XPathNavigator node = nodes.Current.Clone();
                            
                            //next level of check even though text is reset before
                            if (XPathQueryResultTextBox.Text.Length == 0)
                            {
                                XPathQueryResultTextBox.Text = node.OuterXml;
                            }
                            else
                            {
                                XPathQueryResultTextBox.AppendText(Environment.NewLine);
                                XPathQueryResultTextBox.AppendText(node.OuterXml);
                            }

                        }


                        //XPathQueryResultTextBox.ResetText();
                        //XPathQueryResultTextBox.AppendText(XmlNodeListToString(nodesList));

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

        private async void SubmitButton_Click(object sender, EventArgs e)
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

                Stream stream = new MemoryStream();
                XmlWriter writer = XmlWriter.Create(stream);
                // ... build xml here

                stream.Position = 0;
                
                XmlTextWriter myWriter = new XmlTextWriter("result.html", null);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(this.XmlText);
                XmlReader xmlReadB = new XmlTextReader(new StringReader(doc.DocumentElement.OuterXml));
                myXslTrans.Transform(xmlReadB, null, myWriter);
                myWriter.Close();

                string filename = @"result.html";
                char[] result;
                StringBuilder builder = new StringBuilder("Sample XPaths: \n");

                using (StreamReader reader = File.OpenText(filename))
                {
                    result = new char[reader.BaseStream.Length];
                    await reader.ReadAsync(result, 0, (int)reader.BaseStream.Length);
                }
                List<string> XpathList = new List<string>();
                StringBuilder line = new StringBuilder();
                foreach (char c in result)
                {
                    builder.Append(c);
                    line.Append(c);
                    if(c == '\n')
                    {                        
                        XpathList.Add(line.ToString());
                        line.Clear();
                    }
                    
                }

                listBox1.DataSource = XpathList;

                //XPathExamples.ResetText();
                //XPathExamples.AppendText(builder.ToString());
                Console.WriteLine(builder.ToString());
                





                resetStatusStrip();
            }
            catch(Exception ex)
            {
                showStatusError(ex.Message);
            }            
        }

        private void showStatusError(string message)
        {
            string displayMessage = "Exception: " + message;
            ToolStripStatusLabel1.Text = displayMessage;
            ToolStripStatusLabel1.ForeColor = Color.Red;
            StatusStrip1.Refresh();
            //MessageBox.Show(displayMessage, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            ErrorRichTextBox.ResetText();
            ErrorRichTextBox.AppendText(displayMessage);
        }

        private void resetStatusStrip()
        {
            ToolStripStatusLabel1.Text = "";
            ToolStripStatusLabel1.ForeColor = Color.Black;
            StatusStrip1.Refresh();
            ErrorRichTextBox.ResetText();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            xPath.Text = curItem.Substring(0, curItem.Length - 1);
            //SubmitButton_Click(sender, new EventArgs());

        }
    }
}
