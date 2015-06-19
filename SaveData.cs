using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using System.Windows.Forms;
using System.Globalization;

namespace Rent_Calculator
{
    public class SaveData
    {
        private bool versionTest;
        public bool versionCheck
        {
            get { return versionTest; }
            set { versionTest = value; }
        }

        public void Load(string filePath, RadListView listView, List<List<string>> pattiList, List<List<string>> mikeList)
        {
            int count = 0;
            XDocument doc;
            List<string> sublist1 = new List<string>();
            List<string> sublist2 = new List<string>();
            using (var reader = XmlReader.Create(filePath))
            {
                doc = XDocument.Load(reader);
                foreach (var dc in doc.Descendants("Rent"))
                {
                    versionTest = true;
                    foreach (var dm in doc.Descendants("Month-" + count))
                    {
                        ListViewDataItem item = new ListViewDataItem();
                        foreach (XElement x in dm.Descendants())
                            item.SubItems.Add(x.Value);
                        item.TextAlignment = ContentAlignment.MiddleCenter;
                        listView.Items.Add(item);
                    }
                    count++;
                }
                foreach (var ds in doc.Descendants("Month"))
                {
                    versionTest = false;
                    ListViewDataItem item = new ListViewDataItem();
                    foreach (XElement x in ds.Descendants()){
                        item.SubItems.Add(x.Value);
                    }
                    item.TextAlignment = ContentAlignment.MiddleCenter;
                    listView.Items.Add(item);
                    pattiList.Add(new List<string>() { convertToDouble(item[1].ToString()), convertToDouble(item[2].ToString()), convertToDouble(item[3].ToString()), convertToDouble(item[4].ToString()) });
                    mikeList.Add(new List<string>() { convertToDouble(item[1].ToString()), convertToDouble(item[2].ToString()), convertToDouble(item[3].ToString()), convertToDouble(item[4].ToString()) });
                }
                reader.Dispose();
                reader.Close();
            }
        }

        public bool testValidity(string filePath)
        {
            try
            {
                XDocument doc;
                using (var reader = XmlReader.Create(filePath))
                {
                    doc = XDocument.Load(reader);
                    foreach (var dc in doc.Descendants("Rent"))
                        return true;
                    foreach (var ds in doc.Descendants("Month"))
                        return true;
                    reader.Dispose();
                    reader.Close();
                    throw new XmlException();
                }
            }
            catch (XmlException)
            {
                MessageBox.Show("Make sure the file being loaded contains valid RentData.", "Invalid Rent Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string convertToDouble(string value)
        {
            double num;
            bool test = Double.TryParse(value, NumberStyles.Currency, null, out num);
            num /= 2;
            if (test)
                return num.ToString();
            else
                return "0";
        }

        public void LoadPayments(string filePath, RadListView lstview, List<List<string>> pattiList, List<List<string>> mikeList)
        {
            try
            {
                int count = 0;
                XDocument doc;
                using (var reader = XmlReader.Create(filePath))
                {
                    doc = XDocument.Load(reader);
                    var data = doc.Root.Elements().Elements("Payments");
                    foreach (var d in data)
                    {
                        var patti = d.Element("Patti");

                        pattiList.Add(new List<string>() 
                        { 
                            patti.Attribute("Rent").Value, 
                            patti.Attribute("Water").Value,
                            patti.Attribute("Electricity").Value,
                            patti.Attribute("Internet").Value 
                        });

                        var mike = d.Element("Mike");
                        mikeList.Add(new List<string>() 
                        { 
                            mike.Attribute("Rent").Value, 
                            mike.Attribute("Water").Value, 
                            mike.Attribute("Electricity").Value, 
                            mike.Attribute("Internet").Value 
                        });
                    }
                    count++;
                    reader.Dispose();
                    reader.Close();
                }
            }
            catch (XmlException)
            {
                Write(lstview, pattiList, mikeList);
            }
        }

        public void Write(RadListView listView, List<List<string>> pattiList, List<List<string>> mikeList)
        {
            int count = 0;
            string[] elements = { "Rent", "Electricity", "Internet", "Water" };
            XmlWriterSettings settings = new XmlWriterSettings() { Indent = true };
            using (var writer = XmlWriter.Create(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RentData.xml"), settings))
            {
                
                writer.WriteStartDocument();
                writer.WriteComment("Rent Calculator Save Data");
                writer.WriteStartElement("Rent");
                foreach (ListViewDataItem item in listView.Items)
                {
                    writer.WriteStartElement("Month-" + count);
                    writer.WriteElementString("Date", item[0].ToString());
                    writer.WriteElementString("Rent", item[1].ToString());
                    writer.WriteElementString("Internet", item[2].ToString());
                    writer.WriteElementString("Water", item[3].ToString());
                    writer.WriteElementString("Electricity", item[4].ToString());
                    writer.WriteElementString("totalExepense", item[5].ToString());
                    writer.WriteStartElement("Payments");
                    writer.WriteStartElement("Patti");
                    if (count < pattiList.Count)
                    {
                        writer.WriteAttributeString("Rent", pattiList[count][0]);
                        writer.WriteAttributeString("Water", pattiList[count][1]);
                        writer.WriteAttributeString("Electricity", pattiList[count][2]);
                        writer.WriteAttributeString("Internet", pattiList[count][3]);
                    }
                    else
                        for (int i = 0; i < elements.Length; i++)
                            writer.WriteAttributeString(elements[i], "0");
                    writer.WriteEndElement();
                    writer.WriteStartElement("Mike");
                    if (count < mikeList.Count)
                    {
                        writer.WriteAttributeString("Rent", mikeList[count][0]);
                        writer.WriteAttributeString("Water", mikeList[count][1]);
                        writer.WriteAttributeString("Electricity", mikeList[count][2]);
                        writer.WriteAttributeString("Internet", mikeList[count][3]);
                    }
                    else
                        for (int i = 0; i < elements.Length; i++)
                            writer.WriteAttributeString(elements[i], "0");
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    count++;
                }
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();
            }
        }
    }
}
