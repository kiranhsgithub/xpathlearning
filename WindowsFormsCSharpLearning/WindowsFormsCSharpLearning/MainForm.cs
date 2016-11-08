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
        public string PreviousXPath { get; set; }
        public string CurrentXPath { get; set; }


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
                        XPathQueryResultTextBox.ResetText();
                        XPathQueryResultTextBox.AppendText(this.XmlText);
                        resetStatusStrip();
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

            string xmlString = this.XmlText;
            if (String.IsNullOrEmpty(xmlString))
            {
                xmlString = FullXMLBox.Text;
                if (String.IsNullOrEmpty(xmlString))
                {
                    return false;
                }
                this.XmlText = xmlString;
                if(validateXml(xmlString))
                {
                    XmlReader xmlReader = XmlReader.Create(new StringReader(xmlString));
                    XPathDocument myXPathDoc = new XPathDocument(xmlReader);
                    applyTransformations(myXPathDoc);
                }                
            }

            return validateXml(xmlString);

        }

        private static bool validateXml(string xmlString)
        {
            try
            {
                XmlReader xr = XmlReader.Create(
                new StringReader(xmlString));

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
                applyTransformations(myXPathDoc);

                resetStatusStrip();
            }
            catch(Exception ex)
            {                
                showStatusError(ex.StackTrace);
            }            
        }

        private async void applyTransformations(XPathDocument myXPathDoc)
        {
            
            XslCompiledTransform myXslTrans = new XslCompiledTransform();
            myXslTrans.Load("..\\..\\XPathGenerator.xslt");

            //Stream stream = new MemoryStream();
            //XmlWriter writer = XmlWriter.Create(stream);
            //stream.Position = 0;

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
                if (c == '\n')
                {
                    XpathList.Add(line.ToString());
                    line.Clear();
                }

            }

            listBox1.DataSource = XpathList;

            generateNodeElementsList();

            //XPathExamples.ResetText();
            //XPathExamples.AppendText(builder.ToString());
            Console.WriteLine(builder.ToString());
        }

        private void generateNodeElementsList()
        {
            //TODO implement it
            //XDocument doc = XDocument.Load("test.xml"); // Or whatever
           

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(this.XmlText);
            XmlNodeList nodeList = doc.SelectNodes("//*");
            List<String> nodeListStr = new List<String>();
            List<String> attributeListStr = new List<String>();
            foreach(XmlNode node in nodeList)
            {
                if(!nodeListStr.Contains(node.Name))
                {
                    nodeListStr.Add(node.Name);
                }

                NodeNameComboBox.DataSource = nodeListStr;

                if (node.Attributes != null)
                {
                    for (int i = 0; i < node.Attributes.Count; i++)
                    {
                        string attributeName = node.Attributes.Item(i).Name;
                        if (!attributeListStr.Contains(attributeName))
                        {
                            attributeListStr.Add(attributeName);
                        }
                    }
                }     
            }

            NodeNameComboBox.DataSource = new List<String>(nodeListStr);
            NodeNameAttrComboBox.DataSource = new List<String>(nodeListStr);
            AttributeNameComboBox.DataSource = attributeListStr;

            //var allElements = doc.Descendants();
        }

        private void generateNodeElementsList(XmlDocument doc)
        {
            //TODO implement it
        }

        private void generateAttributesList(string xmlText)
        {
            //TODO implement it
        }

        private void generateAttributesList(XmlDocument doc)
        {
            //TODO implement it
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

        private void SearchNodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextSearchXPathButtonClick(object sender, EventArgs e)
        {
            int selectedNodeNameIndex = NodeNameComboBox.SelectedIndex;
            if(selectedNodeNameIndex == -1)
            {
                MessageBox.Show("Please Select a Node Name", "Node Name Selection",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            String nodeName = NodeNameComboBox.SelectedItem.ToString();

            int selectedConditionIndex = SearchNodeConditionTextComboBox.SelectedIndex;
            if (selectedConditionIndex == -1)
            {
                MessageBox.Show("Enter Search Criteria", "Condition", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            String condition = SearchNodeConditionTextComboBox.SelectedItem.ToString();

            string searchText = SearchNodeTextBox.Text;
            if (String.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Enter Search Text in the Text Box", "Search Text", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string oldXPath = xPath.Text;
            string replacableValue = "";
            if (condition.Equals("contains"))
            {
                replacableValue  = nodeName + "[" + condition
                    + "(text(),\"";

                if(xPath.Text.Contains(replacableValue))
                {
                    string xpath = xPath.Text.Substring(0, xPath.Text.IndexOf(replacableValue) 
                        + replacableValue.Length);
                    xPath.Text = xpath + searchText + "\")]";
                }
                else
                {
                    xPath.Text = xPath.Text.Replace
                    (nodeName, replacableValue + searchText + "\")]");
                }
                

            }
            else if(condition.Equals("starts-with(select parent)"))
            {
                //Example 
                //       /catalog/book[starts-with(author,"Gam")]
                string part0 = xPath.Text.Substring(0,xPath.Text.IndexOf(nodeName) + nodeName.Length);
                string part1 = xPath.Text.Substring(xPath.Text.IndexOf(nodeName) + nodeName.Length );
                string part2 = "";
                string part3 = "";
                if (part1.Contains("/"))
                {
                    int slashIndex = part1.IndexOf("/",1);
                    if (slashIndex != -1)
                    {
                        part2 = part1.Substring(0, slashIndex);
                        part3 = part1.Substring(slashIndex, part1.Length);
                    }else
                    {
                        part2 = part1.Substring(1);
                        part3 = "";
                    }
                    
                }

                replacableValue = nodeName + "[starts-with(";
                if (xPath.Text.Contains(replacableValue))
                {
                    int rIndex = oldXPath.IndexOf(replacableValue)
                                            + replacableValue.Length;
                    int eIndex = oldXPath.Length - 1;
                    //MessageBox.Show("Start Index " +  rIndex + ", End Index : " + eIndex);
                    string temPart2 = oldXPath.Substring(rIndex, eIndex - rIndex);

                    int cIndex = temPart2.IndexOf(",\"");

                    part2 = temPart2.Substring(0, cIndex);
                    part3 = temPart2.Substring(cIndex, temPart2.Length - 1 - cIndex);
                    xPath.Text = oldXPath.Substring(0, rIndex)
                        + part2
                        + ",\"" + searchText + "\")]";
                    //+ part3;
                }
                else
                {
                    xPath.Text = part0 + "[starts-with("
                    + part2
                    + ",\"" + searchText + "\")]"
                    + part3;
                }
               


            }
            else if (condition.Equals("starts-with(self)"))
            {
                //Example 
                //   /catalog/book/author[starts-with(.,"Gam")]

                replacableValue = nodeName + "[starts-with(.,\"";

                if (xPath.Text.Contains(replacableValue))
                {
                    string xpath = xPath.Text.Substring(0, xPath.Text.IndexOf(replacableValue)
                        + replacableValue.Length);
                    xPath.Text = xpath + searchText + "\")]";
                }
                else
                {
                    xPath.Text = xPath.Text.Replace
                    (nodeName, replacableValue + searchText + "\")]");
                }


                //xPath.Text = xPath.Text.Replace(nodeName, nodeName + "[starts-with(.,\"" + searchText + "\")]");
            }
            
            //MessageBox.Show(" Old XPath : " + oldXPath + " \n New XPath : " + xPath.Text);
            Console.WriteLine("XPath Text : " + xPath);

        }

        private void AttributeSelectXPathButtonClick(object sender, EventArgs e)
        {
            int selectedNodeNameIndex = NodeNameAttrComboBox.SelectedIndex;
            if (selectedNodeNameIndex == -1)
            {
                MessageBox.Show("Please Select a Node Name", "Node Name Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            String nodeName = NodeNameAttrComboBox.SelectedItem.ToString();

            int selectedAttributeNameIndex = AttributeNameComboBox.SelectedIndex;
            if (selectedAttributeNameIndex == -1)
            {
                MessageBox.Show("Please Select a Attribute Name", "Attribute", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            String attributeName = AttributeNameComboBox.SelectedItem.ToString();

            int selectedAttributeConditionIndex = AttributeConditionComboBox.SelectedIndex;
            if (selectedAttributeConditionIndex == -1)
            {
                MessageBox.Show("Select Attribute Condition", "Attribute Condition", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string attributeCondition = AttributeConditionComboBox.SelectedItem.ToString();

            string attrValue = AttributeValueTextBox.Text;
            if (String.IsNullOrEmpty(attrValue))
            {
                MessageBox.Show("Enter Attribute Value in the Text Box", "Attribute Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string oldXPath = xPath.Text;
            string conditionEquivalent = "";
            if(attributeCondition.Equals("equals"))
            {
                conditionEquivalent = "=";
            }

            string replacableValue = nodeName + "[@";

            if (xPath.Text.Contains(replacableValue))
            {
                string xpath = xPath.Text.Substring(0, xPath.Text.IndexOf(replacableValue)
                    + replacableValue.Length);

                string tempPart = xPath.Text.Substring(xPath.Text.IndexOf(replacableValue)
                    + replacableValue.Length);

                string finalPart = tempPart.Substring(tempPart.IndexOf("\"]"));
                xPath.Text = xpath + attributeName + conditionEquivalent 
                    + "\"" + attrValue 
                    + finalPart;
            }
            else
            {
                xPath.Text = xPath.Text.Replace(nodeName, nodeName 
                    + "[@" + attributeName + conditionEquivalent + "\"" + attrValue + "\"]");

            }

            //xPath.Text = xPath.Text.Replace(nodeName, nodeName + "[@"+ attributeName + conditionEquivalent  + "\"" + attrValue + "\"]");
            //MessageBox.Show(" Old XPath : " + oldXPath + " \n New XPath : " + xPath.Text);
            Console.WriteLine("XPath Text : " + xPath);

        }

        private void ResetAllButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }
    }
}
