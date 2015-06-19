namespace Rent_Calculator
{
    partial class RentCalculator
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Date");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Rent");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Internet");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Utilities (Water)");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn5 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 4", "Utilities (Electricity)");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn6 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 5", "Total Expense");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentCalculator));
            this.lstRent = new Telerik.WinControls.UI.RadListView();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.radInformation = new Telerik.WinControls.UI.RadPanel();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.txtMikeRent = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txtPattiRent = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radPanel5 = new Telerik.WinControls.UI.RadPanel();
            this.radDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.txtMikeInternet = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txtPattiInternet = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtMikeElectric = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txtPattiElectric = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtMikeWater = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txtPattiWater = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lstRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radInformation)).BeginInit();
            this.radInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMikeRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPattiRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMikeInternet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPattiInternet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMikeElectric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPattiElectric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMikeWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPattiWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lstRent
            // 
            this.lstRent.AllowColumnReorder = false;
            this.lstRent.AllowColumnResize = false;
            this.lstRent.AllowEdit = false;
            this.lstRent.AllowRemove = false;
            listViewDetailColumn1.HeaderText = "Date";
            listViewDetailColumn1.MaxWidth = 90F;
            listViewDetailColumn1.MinWidth = 90F;
            listViewDetailColumn1.Width = 90F;
            listViewDetailColumn2.HeaderText = "Rent";
            listViewDetailColumn2.MaxWidth = 100F;
            listViewDetailColumn2.MinWidth = 0F;
            listViewDetailColumn2.Width = 75F;
            listViewDetailColumn3.HeaderText = "Internet";
            listViewDetailColumn3.MaxWidth = 125F;
            listViewDetailColumn3.MinWidth = 0F;
            listViewDetailColumn3.Width = 75F;
            listViewDetailColumn4.HeaderText = "Utilities (Water)";
            listViewDetailColumn4.MaxWidth = 200F;
            listViewDetailColumn4.MinWidth = 75F;
            listViewDetailColumn4.Width = 100F;
            listViewDetailColumn5.HeaderText = "Utilities (Electricity)";
            listViewDetailColumn5.MaxWidth = 200F;
            listViewDetailColumn5.MinWidth = 0F;
            listViewDetailColumn5.Width = 125F;
            listViewDetailColumn6.HeaderText = "Total Expense";
            listViewDetailColumn6.MaxWidth = 90F;
            listViewDetailColumn6.MinWidth = 90F;
            listViewDetailColumn6.Width = 90F;
            this.lstRent.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3,
            listViewDetailColumn4,
            listViewDetailColumn5,
            listViewDetailColumn6});
            this.lstRent.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstRent.HotTracking = false;
            this.lstRent.ItemSpacing = -1;
            this.lstRent.Location = new System.Drawing.Point(0, 0);
            this.lstRent.Name = "lstRent";
            this.lstRent.Size = new System.Drawing.Size(571, 439);
            this.lstRent.TabIndex = 0;
            this.lstRent.Text = "radListView1";
            this.lstRent.ThemeName = "VisualStudio2012Light";
            this.lstRent.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            this.lstRent.SelectedIndexChanged += new System.EventHandler(this.lstRent_SelectedIndexChanged);
            this.lstRent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstRent_KeyDown);
            this.lstRent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstRent_MouseDown);
            // 
            // radInformation
            // 
            this.radInformation.Controls.Add(this.radLabel7);
            this.radInformation.Controls.Add(this.radLabel8);
            this.radInformation.Controls.Add(this.txtMikeRent);
            this.radInformation.Controls.Add(this.txtPattiRent);
            this.radInformation.Controls.Add(this.radPanel5);
            this.radInformation.Controls.Add(this.radDate);
            this.radInformation.Controls.Add(this.radLabel5);
            this.radInformation.Controls.Add(this.radLabel6);
            this.radInformation.Controls.Add(this.txtMikeInternet);
            this.radInformation.Controls.Add(this.txtPattiInternet);
            this.radInformation.Controls.Add(this.radLabel3);
            this.radInformation.Controls.Add(this.radLabel4);
            this.radInformation.Controls.Add(this.txtMikeElectric);
            this.radInformation.Controls.Add(this.txtPattiElectric);
            this.radInformation.Controls.Add(this.radLabel2);
            this.radInformation.Controls.Add(this.radLabel1);
            this.radInformation.Controls.Add(this.txtMikeWater);
            this.radInformation.Controls.Add(this.txtPattiWater);
            this.radInformation.Controls.Add(this.radPanel2);
            this.radInformation.Controls.Add(this.radPanel3);
            this.radInformation.Controls.Add(this.radPanel4);
            this.radInformation.Dock = System.Windows.Forms.DockStyle.Right;
            this.radInformation.Location = new System.Drawing.Point(577, 0);
            this.radInformation.Name = "radInformation";
            this.radInformation.Size = new System.Drawing.Size(239, 439);
            this.radInformation.TabIndex = 1;
            this.radInformation.Text = "Information";
            this.radInformation.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radLabel7
            // 
            this.radLabel7.Location = new System.Drawing.Point(52, 371);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(31, 18);
            this.radLabel7.TabIndex = 19;
            this.radLabel7.Text = "Patti:";
            // 
            // radLabel8
            // 
            this.radLabel8.Location = new System.Drawing.Point(155, 371);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(33, 18);
            this.radLabel8.TabIndex = 18;
            this.radLabel8.Text = "Mike:";
            // 
            // txtMikeRent
            // 
            this.txtMikeRent.IsReadOnly = true;
            this.txtMikeRent.Location = new System.Drawing.Point(134, 395);
            this.txtMikeRent.Name = "txtMikeRent";
            this.txtMikeRent.Size = new System.Drawing.Size(79, 20);
            this.txtMikeRent.TabIndex = 14;
            this.txtMikeRent.TabStop = false;
            this.txtMikeRent.Text = "0";
            this.txtMikeRent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPattiRent
            // 
            this.txtPattiRent.IsReadOnly = true;
            this.txtPattiRent.Location = new System.Drawing.Point(28, 395);
            this.txtPattiRent.Name = "txtPattiRent";
            this.txtPattiRent.Size = new System.Drawing.Size(79, 20);
            this.txtPattiRent.TabIndex = 13;
            this.txtPattiRent.TabStop = false;
            this.txtPattiRent.Text = "0";
            this.txtPattiRent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radPanel5
            // 
            this.radPanel5.Location = new System.Drawing.Point(18, 342);
            this.radPanel5.Name = "radPanel5";
            this.radPanel5.Size = new System.Drawing.Size(206, 82);
            this.radPanel5.TabIndex = 12;
            this.radPanel5.Text = "Rent";
            this.radPanel5.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radDate
            // 
            this.radDate.Location = new System.Drawing.Point(28, 32);
            this.radDate.Name = "radDate";
            this.radDate.Size = new System.Drawing.Size(185, 20);
            this.radDate.TabIndex = 2;
            this.radDate.TabStop = false;
            this.radDate.Text = "Friday, January 16, 2015";
            this.radDate.Value = new System.DateTime(2015, 1, 16, 17, 37, 52, 0);
            this.radDate.ValueChanged += new System.EventHandler(this.radDate_ValueChanged);
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(52, 280);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(31, 18);
            this.radLabel5.TabIndex = 11;
            this.radLabel5.Text = "Patti:";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(155, 280);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(33, 18);
            this.radLabel6.TabIndex = 10;
            this.radLabel6.Text = "Mike:";
            // 
            // txtMikeInternet
            // 
            this.txtMikeInternet.Location = new System.Drawing.Point(134, 304);
            this.txtMikeInternet.Name = "txtMikeInternet";
            this.txtMikeInternet.Size = new System.Drawing.Size(79, 20);
            this.txtMikeInternet.TabIndex = 11;
            this.txtMikeInternet.Text = "0";
            this.txtMikeInternet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMikeInternet.TextChanged += new System.EventHandler(this.txtMikeInternet_TextChanged);
            this.txtMikeInternet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMikeInternet_KeyPress);
            this.txtMikeInternet.Leave += new System.EventHandler(this.txtMikeInternet_Leave);
            // 
            // txtPattiInternet
            // 
            this.txtPattiInternet.Location = new System.Drawing.Point(28, 304);
            this.txtPattiInternet.Name = "txtPattiInternet";
            this.txtPattiInternet.Size = new System.Drawing.Size(79, 20);
            this.txtPattiInternet.TabIndex = 10;
            this.txtPattiInternet.Text = "0";
            this.txtPattiInternet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPattiInternet.TextChanged += new System.EventHandler(this.txtPattiInternet_TextChanged);
            this.txtPattiInternet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPattiInternet_KeyPress);
            this.txtPattiInternet.Leave += new System.EventHandler(this.txtPattiInternet_Leave);
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(52, 191);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(31, 18);
            this.radLabel3.TabIndex = 7;
            this.radLabel3.Text = "Patti:";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(155, 191);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(33, 18);
            this.radLabel4.TabIndex = 6;
            this.radLabel4.Text = "Mike:";
            // 
            // txtMikeElectric
            // 
            this.txtMikeElectric.Location = new System.Drawing.Point(134, 215);
            this.txtMikeElectric.Name = "txtMikeElectric";
            this.txtMikeElectric.Size = new System.Drawing.Size(79, 20);
            this.txtMikeElectric.TabIndex = 8;
            this.txtMikeElectric.Text = "0";
            this.txtMikeElectric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMikeElectric.TextChanged += new System.EventHandler(this.txtMikeElectric_TextChanged);
            this.txtMikeElectric.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMikeElectric_KeyPress);
            this.txtMikeElectric.Leave += new System.EventHandler(this.txtMikeElectric_Leave);
            // 
            // txtPattiElectric
            // 
            this.txtPattiElectric.Location = new System.Drawing.Point(28, 215);
            this.txtPattiElectric.Name = "txtPattiElectric";
            this.txtPattiElectric.Size = new System.Drawing.Size(79, 20);
            this.txtPattiElectric.TabIndex = 7;
            this.txtPattiElectric.Text = "0";
            this.txtPattiElectric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPattiElectric.TextChanged += new System.EventHandler(this.txtPattiElectric_TextChanged);
            this.txtPattiElectric.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPattiElectric_KeyPress);
            this.txtPattiElectric.Leave += new System.EventHandler(this.txtPattiElectric_Leave);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(52, 103);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(31, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Patti:";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(155, 103);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(33, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Mike:";
            // 
            // txtMikeWater
            // 
            this.txtMikeWater.Location = new System.Drawing.Point(134, 127);
            this.txtMikeWater.Name = "txtMikeWater";
            this.txtMikeWater.Size = new System.Drawing.Size(79, 20);
            this.txtMikeWater.TabIndex = 5;
            this.txtMikeWater.Text = "0";
            this.txtMikeWater.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMikeWater.TextChanged += new System.EventHandler(this.txtMikeWater_TextChanged);
            this.txtMikeWater.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMikeWater_KeyPress);
            this.txtMikeWater.Leave += new System.EventHandler(this.txtMikeWater_Leave);
            // 
            // txtPattiWater
            // 
            this.txtPattiWater.Location = new System.Drawing.Point(28, 127);
            this.txtPattiWater.Name = "txtPattiWater";
            this.txtPattiWater.Size = new System.Drawing.Size(79, 20);
            this.txtPattiWater.TabIndex = 4;
            this.txtPattiWater.Text = "0";
            this.txtPattiWater.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPattiWater.TextChanged += new System.EventHandler(this.txtPattiWater_TextChanged);
            this.txtPattiWater.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPattiWater_KeyPress);
            this.txtPattiWater.Leave += new System.EventHandler(this.txtPattiWater_Leave);
            // 
            // radPanel2
            // 
            this.radPanel2.Location = new System.Drawing.Point(18, 78);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(206, 82);
            this.radPanel2.TabIndex = 3;
            this.radPanel2.Text = "Utilities (Water)";
            this.radPanel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radPanel3
            // 
            this.radPanel3.Location = new System.Drawing.Point(18, 166);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(206, 82);
            this.radPanel3.TabIndex = 6;
            this.radPanel3.Text = "Utilities (Electricity)";
            this.radPanel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radPanel4
            // 
            this.radPanel4.Location = new System.Drawing.Point(18, 254);
            this.radPanel4.Name = "radPanel4";
            this.radPanel4.Size = new System.Drawing.Size(206, 82);
            this.radPanel4.TabIndex = 9;
            this.radPanel4.Text = "Internet";
            this.radPanel4.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RentCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 439);
            this.Controls.Add(this.radInformation);
            this.Controls.Add(this.lstRent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RentCalculator";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent Calculator";
            this.ThemeName = "VisualStudio2012Light";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RentCalculator_FormClosing);
            this.Load += new System.EventHandler(this.RentCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radInformation)).EndInit();
            this.radInformation.ResumeLayout(false);
            this.radInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMikeRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPattiRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMikeInternet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPattiInternet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMikeElectric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPattiElectric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMikeWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPattiWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadContextMenu lstMenu;
        public Telerik.WinControls.UI.RadListView lstRent;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadPanel radInformation;
        private Telerik.WinControls.UI.RadDateTimePicker radDate;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadPanel radPanel5;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadPanel radPanel4;
        private System.Windows.Forms.Timer timer1;
        public Telerik.WinControls.UI.RadTextBoxControl txtMikeInternet;
        public Telerik.WinControls.UI.RadTextBoxControl txtPattiInternet;
        public Telerik.WinControls.UI.RadTextBoxControl txtMikeElectric;
        public Telerik.WinControls.UI.RadTextBoxControl txtPattiElectric;
        public Telerik.WinControls.UI.RadTextBoxControl txtMikeWater;
        public Telerik.WinControls.UI.RadTextBoxControl txtPattiWater;
        public Telerik.WinControls.UI.RadTextBoxControl txtMikeRent;
        public Telerik.WinControls.UI.RadTextBoxControl txtPattiRent;
    }
}
