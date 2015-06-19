using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using System.Linq;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Themes;

namespace Rent_Calculator
{
    public partial class InputDialog : Telerik.WinControls.UI.RadForm
    {
        public string input = "";
        public InputDialog()
        {
            InitializeComponent();

            VisualStudio2012LightTheme theme = new VisualStudio2012LightTheme();
            ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Light";
        }

        private void txtRent_TextChanged(object sender, EventArgs e)
        {
            textBoxValidator(txtRent, 99999, 0);
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
                }
                else if (!Double.TryParse(textBox.Text, out num))
                {
                    if (textBox.Text != "")
                    {
                        textBox.Text = "0";
                        textBox.CaretIndex = textBox.TextLength;
                    }
                }
            }
            catch (Exception)
            {
                textBox.Text = "0";
            }
        }

        private void txtInternet_TextChanged(object sender, EventArgs e)
        {
            textBoxValidator(txtInternet, 99999, 0);
        }

        private void txtWater_TextChanged(object sender, EventArgs e)
        {
            textBoxValidator(txtWater, 99999, 0);
        }

        private void txtElectricity_TextChanged(object sender, EventArgs e)
        {
            textBoxValidator(txtElectricity, 99999, 0);
        }

        private void txtRent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

        private void txtInternet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;

        }

        private void txtWater_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

        private void txtElectricity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
                e.Handled = true;
        }

        private void txtRent_Leave(object sender, EventArgs e)
        {
            if (txtRent.Text == "")
                txtRent.Text = "0";
        }

        private void txtInternet_Leave(object sender, EventArgs e)
        {
            if (txtInternet.Text == "")
                txtInternet.Text = "0";
        }

        private void txtWater_Leave(object sender, EventArgs e)
        {
            if (txtWater.Text == "")
                txtWater.Text = "0";
        }

        private void txtElectricity_Leave(object sender, EventArgs e)
        {
            if (txtElectricity.Text == "")
                txtElectricity.Text = "0";
        }
    }
}
