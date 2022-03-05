using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBrainApp.Forms
{
    public partial class FormSelectTest : Form
    {

        public FormSelectTest()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
               
                }

            }

            foreach (Control btns in panelButtons.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
        private void FormSelectTest_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close() ;
        }

        private void btnFrist_Click(object sender, EventArgs e)
        {
            SelectedTest.SelectedNum = 1;
            DialogResult = DialogResult.OK;
        }

        private void btnSecond_Click(object sender, EventArgs e)
        {
            SelectedTest.SelectedNum = 2;
            DialogResult = DialogResult.OK;
        }

        private void btnThird_Click(object sender, EventArgs e)
        {
            SelectedTest.SelectedNum = 3;
            DialogResult = DialogResult.OK;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            SelectedTest.SelectedNum = 4;
            DialogResult = DialogResult.OK;
        }
    }
}
