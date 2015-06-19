namespace Rent_Calculator
{
    partial class InputDialog
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
            this.btnOK = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.lblInput = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.txtElectricity = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txtWater = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txtRent = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtInternet = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtElectricity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInternet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(12, 247);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(82, 24);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.ThemeName = "VisualStudio2012Light";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(130, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 24);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.ThemeName = "VisualStudio2012Light";
            // 
            // lblInput
            // 
            this.lblInput.Location = new System.Drawing.Point(38, 30);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(32, 18);
            this.lblInput.TabIndex = 3;
            this.lblInput.Text = "Rent:";
            this.lblInput.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(31, 29);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(39, 18);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Water:";
            this.radLabel2.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(14, 63);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(56, 18);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Electricity:";
            this.radLabel3.ThemeName = "VisualStudio2012Light";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.txtElectricity);
            this.radPanel1.Controls.Add(this.txtWater);
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Controls.Add(this.radLabel3);
            this.radPanel1.Location = new System.Drawing.Point(12, 127);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(200, 100);
            this.radPanel1.TabIndex = 3;
            this.radPanel1.Text = "Utilities";
            this.radPanel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.radPanel1.ThemeName = "VisualStudio2012Light";
            // 
            // txtElectricity
            // 
            this.txtElectricity.Location = new System.Drawing.Point(76, 63);
            this.txtElectricity.Name = "txtElectricity";
            this.txtElectricity.Size = new System.Drawing.Size(105, 20);
            this.txtElectricity.TabIndex = 5;
            this.txtElectricity.Text = "0";
            this.txtElectricity.ThemeName = "VisualStudio2012Light";
            this.txtElectricity.TextChanged += new System.EventHandler(this.txtElectricity_TextChanged);
            this.txtElectricity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtElectricity_KeyPress);
            this.txtElectricity.Leave += new System.EventHandler(this.txtElectricity_Leave);
            // 
            // txtWater
            // 
            this.txtWater.Location = new System.Drawing.Point(76, 27);
            this.txtWater.Name = "txtWater";
            this.txtWater.Size = new System.Drawing.Size(105, 20);
            this.txtWater.TabIndex = 4;
            this.txtWater.Text = "0";
            this.txtWater.ThemeName = "VisualStudio2012Light";
            this.txtWater.TextChanged += new System.EventHandler(this.txtWater_TextChanged);
            this.txtWater.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWater_KeyPress);
            this.txtWater.Leave += new System.EventHandler(this.txtWater_Leave);
            // 
            // txtRent
            // 
            this.txtRent.Location = new System.Drawing.Point(76, 28);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(105, 20);
            this.txtRent.TabIndex = 1;
            this.txtRent.Text = "0";
            this.txtRent.ThemeName = "VisualStudio2012Light";
            this.txtRent.TextChanged += new System.EventHandler(this.txtRent_TextChanged);
            this.txtRent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRent_KeyPress);
            this.txtRent.Leave += new System.EventHandler(this.txtRent_Leave);
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(19, 65);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(51, 18);
            this.radLabel4.TabIndex = 9;
            this.radLabel4.Text = "Internet: ";
            this.radLabel4.ThemeName = "VisualStudio2012Light";
            // 
            // txtInternet
            // 
            this.txtInternet.Location = new System.Drawing.Point(76, 63);
            this.txtInternet.Name = "txtInternet";
            this.txtInternet.Size = new System.Drawing.Size(105, 20);
            this.txtInternet.TabIndex = 2;
            this.txtInternet.Text = "0";
            this.txtInternet.ThemeName = "VisualStudio2012Light";
            this.txtInternet.TextChanged += new System.EventHandler(this.txtInternet_TextChanged);
            this.txtInternet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInternet_KeyPress);
            this.txtInternet.Leave += new System.EventHandler(this.txtInternet_Leave);
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.txtInternet);
            this.radPanel2.Controls.Add(this.lblInput);
            this.radPanel2.Controls.Add(this.radLabel4);
            this.radPanel2.Controls.Add(this.txtRent);
            this.radPanel2.Location = new System.Drawing.Point(12, 10);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(200, 100);
            this.radPanel2.TabIndex = 0;
            this.radPanel2.Text = "Other Expenses";
            this.radPanel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.radPanel2.ThemeName = "VisualStudio2012Light";
            // 
            // InputDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(225, 282);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputDialog";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Month";
            this.ThemeName = "VisualStudio2012Light";
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtElectricity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInternet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Telerik.WinControls.UI.RadButton btnOK;
        public Telerik.WinControls.UI.RadButton btnCancel;
        public Telerik.WinControls.UI.RadLabel lblInput;
        public Telerik.WinControls.UI.RadLabel radLabel2;
        public Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        public Telerik.WinControls.UI.RadTextBoxControl txtElectricity;
        public Telerik.WinControls.UI.RadTextBoxControl txtWater;
        public Telerik.WinControls.UI.RadTextBoxControl txtRent;
        public Telerik.WinControls.UI.RadLabel radLabel4;
        public Telerik.WinControls.UI.RadTextBoxControl txtInternet;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}
