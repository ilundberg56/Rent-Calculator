using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using Telerik.Windows;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Themes;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using System.Globalization;
using System.Collections;
using System.IO;

namespace Rent_Calculator
{
    public partial class RentCalculator : Telerik.WinControls.UI.RadForm
    {
        // 0-rent, 1-internet, 2-water, 3-electric, 4-total
        public static double[] expenses;
        public double plcHold;
        public bool test;
        public bool menuOpened; 
        public string filePath;
        public RadTextBoxControl[] txtControls;
        public List<List<string>> savedPattiValues;
        public List<List<string>> savedMikeValues;
        private RadContextMenu contextMenu1;
        SaveData data;

        public RentCalculator()
        {
            InitializeComponent();

            VisualStudio2012LightTheme theme = new VisualStudio2012LightTheme();
            ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Light";

            data = new SaveData();
            test = false;
            plcHold = 0;
            expenses = new double[5];
            menuOpened = false;
            filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RentData.xml");
            txtControls = new RadTextBoxControl[] { txtMikeRent, txtPattiRent, txtMikeInternet, txtPattiInternet, 
                txtMikeWater, txtPattiWater, txtMikeElectric, txtPattiElectric };
            savedPattiValues = new List<List<string>>();
            savedMikeValues = new List<List<string>>();
            contextMenu1 = new RadContextMenu();
            lstMenu = new RadContextMenu();
        }

        private void RentCalculator_Load(object sender, EventArgs e)
        {
            createContextMenu1();
            createContextMenu2();
            if (data.testValidity(filePath))
            {
                data.Load(filePath, lstRent, savedPattiValues, savedMikeValues);
                data.LoadPayments(filePath, lstRent, savedPattiValues, savedMikeValues);
                if (lstRent.Items.Count > 0)
                {
                    lstRent.SelectedIndex = 0;
                    ListViewDataItem item = lstRent.SelectedItem;
                    radDate.Value = Convert.ToDateTime(item[0].ToString());
                }
                if (!data.versionCheck)
                {
                    if (MessageBox.Show("You are using an outdated save format.\nWould you like to create a backup in case of technical errors? (Recommended)", "Create Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        backupFileDialog();
                    this.Activate();
                }
                else
                    distributeLists();
                test = true;
            }
        }

        private void createContextMenu1()
        {
            RadMenuItem firstItem = new RadMenuItem("Add");
            firstItem.Click += new EventHandler(radMenuAdd_Click);
            RadMenuItem secondItem = new RadMenuItem("Backup");
            secondItem.Click += new EventHandler(radMenuBackup_Click);
            RadMenuItem thirdItem = new RadMenuItem("Import");
            thirdItem.Click += new EventHandler(radMenuImport_Click);
            contextMenu1.Items.Add(firstItem);
            contextMenu1.Items.Add(secondItem);
            contextMenu1.Items.Add(thirdItem);
        }

        private void createContextMenu2()
        {
            RadMenuItem firstItem = new RadMenuItem("Add");
            firstItem.Click += new EventHandler(radMenuAdd_Click);
            RadMenuItem secondItem = new RadMenuItem("Edit");
            secondItem.Click += new EventHandler(radMenuEdit_Click);
            RadMenuItem thirdItem = new RadMenuItem("Delete");
            thirdItem.Click += new EventHandler(radMenuDelete_Click);
            RadMenuItem fourthItem = new RadMenuItem("Backup");
            fourthItem.Click += new EventHandler(radMenuBackup_Click);
            RadMenuItem fifthItem = new RadMenuItem("Import");
            fifthItem.Click += new EventHandler(radMenuImport_Click);
            lstMenu.Items.Add(firstItem);
            lstMenu.Items.Add(secondItem);
            lstMenu.Items.Add(thirdItem);
            lstMenu.Items.Add(fourthItem);
            lstMenu.Items.Add(fifthItem);
        }

        private void backupFileDialog()
        {
            SaveFileDialog saveBackup = new SaveFileDialog();
            saveBackup.Title = "Backup";
            saveBackup.FileName = "RentData.xml";
            saveBackup.Filter = "XML File | *.xml";
            saveBackup.DefaultExt = "RentData.xml";
            if(saveBackup.ShowDialog() == DialogResult.OK)
            {
                string newDirectory = saveBackup.FileName;
                if (File.Exists(newDirectory))
                {
                    File.Delete(newDirectory);
                    File.Copy(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RentData.xml"), newDirectory);
                    this.BringToFront();
                }
                else
                    File.Copy(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RentData.xml"), newDirectory);
                this.BringToFront();
            }
        }

        private void addMonth(string rent, string internet, string water, string electricity)
        {
            string[] array = { rent, internet, water, electricity };
            ListViewDataItem item = new ListViewDataItem();
            item.SubItems.Add(DateTime.Now.ToString("MM/dd/yyyy"));
            foreach (string a in array)
                item.SubItems.Add(String.Format("{0:C}", Convert.ToDouble(a)));
            item.SubItems.Add(String.Format("{0:C}", calcTotal(array)));
            item.TextAlignment = ContentAlignment.MiddleCenter;
            lstRent.Items.Add(item);
            distributeCosts();
            addNewList();
            data.Write(lstRent, savedPattiValues, savedMikeValues);
        }

        private void editMonth(string rent, string internet, string water, string electricity)
        {
            double[] items = new double[5];
            string[] array = { rent, internet, water, electricity };
            ListViewDataItem item = lstRent.SelectedItem;
            for (int i = 1; i < 5; i++)
                item[i] = String.Format("{0:C}", Double.Parse(array[i - 1], NumberStyles.Currency));
            item[5] = String.Format("{0:C}", calcTotal(array));
            item.TextAlignment = ContentAlignment.MiddleCenter;
            distributeCosts();
            updateLists();
            data.Write(lstRent, savedPattiValues, savedMikeValues);

        }

        public static DialogResult createMonth(ref string rent, ref string water, ref string electricity, ref string internet)
        {
            InputDialog dialog = new InputDialog();
            DialogResult dialogResult = dialog.ShowDialog();
            rent = dialog.txtRent.Text;
            water = dialog.txtWater.Text;
            electricity = dialog.txtElectricity.Text;
            internet = dialog.txtInternet.Text;
            return dialogResult;
        }

        public static DialogResult createMonth(ref string rent, ref string water, ref string electricity, ref string internet, string text1, string text2, string text3, string text4)
        {
            InputDialog dialog = new InputDialog();
            dialog.txtRent.Text = Double.Parse(text1, NumberStyles.Currency).ToString();
            dialog.txtInternet.Text = Double.Parse(text2, NumberStyles.Currency).ToString();
            dialog.txtWater.Text = Double.Parse(text3, NumberStyles.Currency).ToString();
            dialog.txtElectricity.Text = Double.Parse(text4, NumberStyles.Currency).ToString();
            dialog.Text = "Edit Month";
            DialogResult dialogResult = dialog.ShowDialog();
            rent = dialog.txtRent.Text;
            water = dialog.txtWater.Text;
            electricity = dialog.txtElectricity.Text;
            internet = dialog.txtInternet.Text;
            return dialogResult;
        }

        private double calcTotal(string[] array)
        {
            double total = 0;
            foreach (string a in array)
                total += Double.Parse(a, NumberStyles.Currency);
            return total;
            
        }

        private void lstRent_MouseDown(object sender, MouseEventArgs e)
        {
            
            if(e.Button == MouseButtons.Right)
            {
                dynamic clickedCell = this.lstRent.ElementTree.GetElementAtPoint(e.Location) as DetailListViewDataCellElement;
                if (clickedCell != null)
                {
                    this.lstRent.SelectedItem = clickedCell.Row;
                    this.lstRent.CurrentColumn = clickedCell.Data;
                    lstMenu.Show(MousePosition);
                }
                else
                    contextMenu1.Show(MousePosition);
            }
        }

        private void radDate_ValueChanged(object sender, EventArgs e)
        {
            if (lstRent.Items.Count > 0)
            {
                ListViewDataItem item = lstRent.Items[lstRent.SelectedIndex];
                item[0] = radDate.Value.ToString("MM/dd/yyyy");
            }
            
        }

        private void lstRent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRent.Items.Count > 0)
            {
                if (lstRent.SelectedIndex < 0 || lstRent.SelectedIndex > lstRent.Items.Count)
                    lstRent.SelectedIndex = 0;
                if (!data.versionCheck)
                    distributeCosts();
                if (lstRent.Items.Count > 0 && test == true)
                {
                    distributeLists();       
                    ListViewDataItem item = lstRent.Items[lstRent.SelectedIndex];
                    radDate.Value = Convert.ToDateTime(item[0].ToString());
                    data.Write(lstRent, savedPattiValues, savedMikeValues);
                }

            }
        }
        private void addNewList()
        {
            List<string> sublistMike = new List<string>();
            List<string> sublistPatti = new List<string>();
            sublistPatti.Add(txtPattiRent.Text);
            sublistMike.Add(txtMikeRent.Text);
            sublistPatti.Add(txtPattiWater.Text);
            sublistMike.Add(txtMikeWater.Text);
            sublistPatti.Add(txtPattiElectric.Text);
            sublistMike.Add(txtMikeElectric.Text);
            sublistPatti.Add(txtPattiInternet.Text);
            sublistMike.Add(txtMikeInternet.Text);
            savedPattiValues.Add(sublistPatti);
            savedMikeValues.Add(sublistMike);
        }
        private void updateLists()
        {
            List<string> sublistMike = new List<string>();
            List<string> sublistPatti = new List<string>();
            string[] tempPatti = { txtPattiRent.Text, txtPattiWater.Text, txtPattiElectric.Text, txtPattiInternet.Text };
            string[] tempMike = { txtMikeRent.Text, txtMikeWater.Text, txtMikeElectric.Text, txtMikeInternet.Text };

            for (int i = 0; i < tempPatti.Length; i++) {
                if (tempPatti[i] == "")
                    tempPatti[i] = "0";
                if (tempMike[i] == "")
                    tempMike[i] = "0";
            }
            sublistPatti.Add(tempPatti[0]);
            sublistMike.Add(tempMike[0]);
            sublistPatti.Add(tempPatti[1]);
            sublistMike.Add(tempMike[1]);
            sublistPatti.Add(tempPatti[2]);
            sublistMike.Add(tempMike[2]);
            sublistPatti.Add(tempPatti[3]);
            sublistMike.Add(tempMike[3]);
            savedPattiValues.RemoveAt(lstRent.SelectedIndex);
            savedMikeValues.RemoveAt(lstRent.SelectedIndex);
            savedMikeValues.Insert(lstRent.SelectedIndex, sublistMike);
            savedPattiValues.Insert(lstRent.SelectedIndex, sublistPatti);
        }

        private void distributeCosts()
        {
            try
            {
                double num;
                ListViewDataItem item = lstRent.SelectedItem;
                for (int i = 1; i < lstRent.Columns.Count; i++)
                {
                    if (Double.TryParse(item[i].ToString(), NumberStyles.Currency, null, out num))
                    {
                        string strNum = Convert.ToString(num / 2);
                        switch (i)
                        {
                            case 1:
                                {
                                    txtMikeRent.Text = strNum;
                                    txtPattiRent.Text = strNum;
                                    expenses[0] = num;
                                    break;
                                }
                            case 2:
                                {
                                    txtMikeInternet.Text = strNum;
                                    txtPattiInternet.Text = strNum;
                                    expenses[1] = num;
                                    break;
                                }
                            case 3:
                                {
                                    txtMikeWater.Text = strNum;
                                    txtPattiWater.Text = strNum;
                                    expenses[2] = num;
                                    break;
                                }
                            case 4:
                                {
                                    txtMikeElectric.Text = strNum;
                                    txtPattiElectric.Text = strNum;
                                    expenses[3] = num;
                                    break;
                                }
                            case 5:
                                {
                                    expenses[4] = num;
                                    break;
                                }
                            default:
                                {
                                    RadMessageBox.Show(null, "i = " + i.ToString(), "DistributeCost()", MessageBoxButtons.OK, RadMessageIcon.Error);
                                    break;
                                }
                        }
                    }
                }
            }
            catch (Exception )
            {}
        }

        private void distributeLists()
        {
            if (lstRent.Items.Count > 0 && lstRent.SelectedIndex < savedMikeValues.Count)
            {
                txtControls[2].Text = savedMikeValues[lstRent.SelectedIndex][3];
                txtControls[3].Text = savedPattiValues[lstRent.SelectedIndex][3];
                expenses[1] = addTogether(savedMikeValues[lstRent.SelectedIndex][3], savedPattiValues[lstRent.SelectedIndex][3]);

                txtControls[4].Text = savedMikeValues[lstRent.SelectedIndex][1];
                txtControls[5].Text = savedPattiValues[lstRent.SelectedIndex][1];
                expenses[2] = addTogether(savedMikeValues[lstRent.SelectedIndex][1], savedPattiValues[lstRent.SelectedIndex][1]);

                txtControls[6].Text = savedMikeValues[lstRent.SelectedIndex][2];
                txtControls[7].Text = savedPattiValues[lstRent.SelectedIndex][2];
                expenses[3] = addTogether(savedMikeValues[lstRent.SelectedIndex][2], savedPattiValues[lstRent.SelectedIndex][2]);

                txtControls[0].Text = savedMikeValues[lstRent.SelectedIndex][0];
                txtControls[1].Text = savedPattiValues[lstRent.SelectedIndex][0];

                expenses[0] = addTogether(savedMikeValues[lstRent.SelectedIndex][0], savedPattiValues[lstRent.SelectedIndex][0]);
            }
        }

        private double addTogether(string str1, string str2)
        {
            return Convert.ToDouble(str1) + Convert.ToDouble(str2);
        }

        // Disables all textboxes
        public void disableTextBoxes(bool b, string text)
        {
            radDate.Enabled = b;
            if (!b)
                radDate.Value = DateTime.Now;

            foreach (RadTextBoxControl ctrl in radInformation.Controls.OfType<RadTextBoxControl>())
            {
                ctrl.Enabled = b;
                ctrl.Text = text;
            }
        }

        public void disableTextBoxes(bool b)
        {
            radDate.Enabled = b;
            if (!b)
                radDate.Value = DateTime.Now;

            foreach (RadTextBoxControl ctrl in radInformation.Controls.OfType<RadTextBoxControl>())
            {
                ctrl.Enabled = b;
            }
        }

        private void txtMikeWater_TextChanged(object sender, EventArgs e)
        {
            double num;
            bool parse = Double.TryParse(txtMikeWater.Text, out num);
            if (txtMikeWater.Focused)
                if (parse && num >= 0 && num <= expenses[2])
                    txtPattiWater.Text = (expenses[2] - num).ToString();
                else if (txtMikeWater.Text == "")
                    txtPattiWater.Text = (expenses[2] - num).ToString();
                else
                    textBoxValidator(txtMikeWater, expenses[2], 0);
            UpdateRent();

        }

        private void txtMikeElectric_TextChanged(object sender, EventArgs e)
        {
            double num;
            bool parse = Double.TryParse(txtMikeElectric.Text, out num);
            if (txtMikeElectric.Focused)
                if (parse && num >= 0 && num <= expenses[3])
                    txtPattiElectric.Text = (expenses[3] - num).ToString();
                else if (txtMikeElectric.Text == "")
                    txtPattiElectric.Text = expenses[3].ToString();
                else
                    textBoxValidator(txtMikeElectric, expenses[3], 0);
            UpdateRent();

        }

        private void txtMikeInternet_TextChanged(object sender, EventArgs e)
        {


            double num;
            bool parse = Double.TryParse(txtMikeInternet.Text, out num);
            if (txtMikeInternet.Focused)
                if (parse && num >= 0 && num <= expenses[1])
                    txtPattiInternet.Text = (expenses[1] - num).ToString();
                else if (txtMikeInternet.Text == "")
                    txtPattiInternet.Text = expenses[1].ToString();
                else
                    textBoxValidator(txtMikeInternet, expenses[1], 0);
            UpdateRent();

        }

        private void txtPattiWater_TextChanged(object sender, EventArgs e)
        {

            double num;
            bool parse = Double.TryParse(txtPattiWater.Text, out num);
            if (txtPattiWater.Focused == true)
                if (parse && num >= 0 && num <= expenses[2])
                    txtMikeWater.Text = (expenses[2] - num).ToString();
                else if (txtPattiWater.Text == "")
                    txtMikeWater.Text = expenses[2].ToString();
                else
                    textBoxValidator(txtPattiWater, expenses[2], 0);
            UpdateRent();
        }

        private void txtPattiElectric_TextChanged(object sender, EventArgs e)
        {

            double num;
            bool parse = Double.TryParse(txtPattiElectric.Text, out num);
            if (txtPattiElectric.Focused)
                if (parse && num >= 0 && num <= expenses[3])
                    txtMikeElectric.Text = (expenses[3] - num).ToString();
                else if (txtPattiElectric.Text == "")
                    txtMikeElectric.Text = expenses[3].ToString();
                else
                    textBoxValidator(txtPattiElectric, expenses[3], 0);
             UpdateRent();
        }

        private void txtPattiInternet_TextChanged(object sender, EventArgs e)
        {
            double num;
            bool parse = Double.TryParse(txtPattiInternet.Text, out num);
            if (txtPattiInternet.Focused)
                if (parse && num >= 0 && num <= expenses[1])
                    txtMikeInternet.Text = (expenses[1] - num).ToString();
                else if (txtPattiInternet.Text == "")
                    txtMikeInternet.Text = expenses[1].ToString();
                else
                    textBoxValidator(txtPattiInternet, expenses[1], 0);
            UpdateRent();
        }

        private void textBoxValidator(RadTextBoxControl textBox, double max, double min)
        {
            try
            {
                double num;
                if (Double.TryParse(textBox.Text, out num) && num > max)
                {
                   
                    textBox.Text = max.ToString();
                    textBox.CaretIndex = textBox.TextLength;
                    updateLists();
                      
                }
                else if (!Double.TryParse(textBox.Text, out num))
                {
                    distributeLists();
                    textBox.CaretIndex = textBox.TextLength;
          

                }
            }
            catch (Exception)
            {
                distributeLists();
            }
        }

        private void UpdateRent()
        {
            var pattiPaid = GetPattiWater() + GetPattiElectric() + GetPattiInternet();
            var mikePaid = GetMikeWater() + GetMikeElectric() + GetMikeInternet();

            var difference = pattiPaid - mikePaid;
            var baseRent = GetRequiredMonthlyRent();

            var pattiRent = (baseRent - difference) / 2;
            var mikeRent = (baseRent + difference) / 2;

            txtPattiRent.Text = pattiRent.ToString();
            txtMikeRent.Text = mikeRent.ToString();

        }
        
        private double GetPattiWater()
        {
            double num;
            if (Double.TryParse(txtPattiWater.Text, out num))
            {
                return num;
            }
            else return 0;
        }
        
        private double GetPattiElectric()
        {
            double num;
            if (Double.TryParse(txtPattiElectric.Text, out num))
            {
                return num;
            }

            else return 0;
            
        }

        private double GetPattiInternet()
        {
            double num;
            if (Double.TryParse(txtPattiInternet.Text, out num))
            {
                return num;
            }
            else return 0;
        }

        private double GetMikeWater()
        {
            double num;
            if (Double.TryParse(txtMikeWater.Text, out num))
            {
                return num;
            }
            else return 0;
        }

        private double GetMikeElectric()
        {
            double num;
            if (Double.TryParse(txtMikeElectric.Text, out num))
            {
                return num;
            }
            else return 0;
        }

        private double GetMikeInternet()
        {
            double num;
            if (Double.TryParse(txtMikeInternet.Text, out num))
            {
                return num;
            }
            else return 0;
        }


        private double GetRequiredMonthlyRent()
        {
            return expenses[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lstRent.Items.Count == 0)
            {
                disableTextBoxes(false, "0");
                radDate.Value = DateTime.Now;
            }
            if (lstRent.Items.Count > 0)
                disableTextBoxes(true);
            if(lstRent.Items.Count > 0 && lstRent.SelectedIndex < savedPattiValues.Count)
            {
                updateLists();
            }

        }

        private void txtPattiWater_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

        private void txtMikeWater_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

        private void txtPattiElectric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

        private void txtMikeElectric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

        private void txtPattiInternet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

        private void txtMikeInternet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

        private void RentCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            data.Write(lstRent, savedPattiValues, savedMikeValues);
        }

        private void radMenuEdit_Click(object sender, EventArgs e)
        {
            string rent = "", water = "", electricity = "", internet = "";

            ListViewDataItem item = lstRent.SelectedItem;
            if (createMonth(ref rent, ref water, ref electricity, ref internet, item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString()) == DialogResult.OK)
                editMonth(rent, internet, water, electricity);
        }

        private void radMenuDelete_Click(object sender, EventArgs e)
        {
            if (savedPattiValues.Count > lstRent.SelectedIndex)
            {
                savedPattiValues.RemoveAt(lstRent.SelectedIndex);
                savedMikeValues.RemoveAt(lstRent.SelectedIndex);
            }
            lstRent.Items.Remove(lstRent.SelectedItem);
            if (lstRent.Items.Count == 0)
                disableTextBoxes(false, "0");
            data.Write(lstRent, savedPattiValues, savedMikeValues);
        }

        private void radMenuAdd_Click(object sender, EventArgs e)
        {
            string rent = "", water = "", electricity = "", internet = "";

            if (createMonth(ref rent, ref water, ref electricity, ref internet) == DialogResult.OK)
            {
                disableTextBoxes(true, "0");
                addMonth(rent, internet, water, electricity);
            }
        }

        private void radMenuImport_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Warning: All data will be overwritten.", "Import", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                OpenFileDialog importData = new OpenFileDialog();
                importData.Title = "Import";
                importData.Filter = "RentData | *.xml";
                if (importData.ShowDialog() == DialogResult.OK)
                {
                    string fileDirectory = importData.FileName;
                    if (data.testValidity(fileDirectory))
                    {
                        lstRent.Items.Clear();
                        savedPattiValues = new List<List<string>>();
                        savedMikeValues = new List<List<string>>();
                        data.Load(fileDirectory, lstRent, savedPattiValues, savedMikeValues);
                        data.LoadPayments(fileDirectory, lstRent, savedPattiValues, savedMikeValues);
                        if (lstRent.Items.Count > 0)
                        {
                            lstRent.SelectedIndex = 0;
                            ListViewDataItem item = lstRent.SelectedItem;
                            radDate.Value = Convert.ToDateTime(item[0].ToString());
                        }

                        if (!data.versionCheck)
                        {
                            if (MessageBox.Show("You are using an outdated save format.\nWould you like to create a backup in case data is lost? (Recommended)", "Create Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                backupFileDialog();
                            distributeCosts();
                        }
                        else
                            distributeLists();
                        test = true;
                    }
                }
            }
        }

        private void radMenuBackup_Click(object sender, EventArgs e)
        {
            data.Write(lstRent, savedPattiValues, savedMikeValues);
            backupFileDialog();
        }

        private void lstRent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (savedPattiValues.Count > lstRent.SelectedIndex)
                {
                    savedPattiValues.RemoveAt(lstRent.SelectedIndex);
                    savedMikeValues.RemoveAt(lstRent.SelectedIndex);
                }
                lstRent.Items.Remove(lstRent.SelectedItem);
                if (lstRent.Items.Count == 0)
                    disableTextBoxes(false, "0");
                data.Write(lstRent, savedPattiValues, savedMikeValues);
            }
        }

        private void txtPattiWater_Leave(object sender, EventArgs e)
        {
            if (txtPattiWater.Text == "")
                txtPattiWater.Text = "0";
        }

        private void txtMikeWater_Leave(object sender, EventArgs e)
        {
            if (txtMikeWater.Text == "")
                txtMikeWater.Text = "0";
        }

        private void txtPattiElectric_Leave(object sender, EventArgs e)
        {
            if (txtPattiElectric.Text == "")
                txtPattiElectric.Text = "0";
        }

        private void txtMikeElectric_Leave(object sender, EventArgs e)
        {
            if (txtMikeElectric.Text == "")
                txtMikeElectric.Text = "0";
        }

        private void txtPattiInternet_Leave(object sender, EventArgs e)
        {
            if (txtPattiInternet.Text == "")
                txtPattiInternet.Text = "0";
        }

        private void txtMikeInternet_Leave(object sender, EventArgs e)
        {
            if (txtMikeInternet.Text == "")
                txtMikeInternet.Text = "0";
        }
    }
}
