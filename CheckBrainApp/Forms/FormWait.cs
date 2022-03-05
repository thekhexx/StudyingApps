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
    public partial class FormWait : Form
    {
        public FormWait()
        {
            InitializeComponent();

        }

        private void FormWait_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormWait_Shown(object sender, EventArgs e)
        {
            FormSelectTest form = new FormSelectTest();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
            this.Close();
        }
    }
}
