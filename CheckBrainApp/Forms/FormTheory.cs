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
    public partial class FormTheory : Form
    {
        public FormTheory()
        {
            InitializeComponent();
            this.ControlBox = false;

        }
        private void LoadTheme()
        {
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

        private void FormTheory_Load(object sender, EventArgs e)
        {
            LoadButtons();
            LoadTheme();
        }

        private void LoadButtons()
        {
            int count = 0;
            foreach (string thr in Theories.TheoryPaths)
            {
                Button btn = new Button();
                btn.Text = thr.Substring(0,thr.IndexOf('.'));
                btn.Tag = count;
                btn.Dock = DockStyle.Bottom;
                panelButtons.Controls.Add(btn);
                btn.Height = 45;
                btn.Click += Btn_Click;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Flat;
                count++;
            }
            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            StartReading(Theories.TheoryPaths[Convert.ToInt32(btn.Tag)]);
        }

        private void StartReading(string theory)
        {
            panelButtons.Visible = false;
            lblMain.Visible = false;
            webTheory.Visible = true;
            setDocumentToBrowser(theory);
        }
        private void setDocumentToBrowser(string theory)
        {
            webTheory.Url = new Uri(Environment.CurrentDirectory + @"\" + theory);
        }
        //private void btnTheoryFirst_Click(object sender, EventArgs e)
        //{
        //    
        //}

        //private void btnTheorySecond_Click(object sender, EventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    StartReading(TestTheory.TheoryPaths[Convert.ToInt32(btn.Tag)]);
        //}

        //private void btnTheoryThird_Click(object sender, EventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    StartReading(TestTheory.TheoryPaths[Convert.ToInt32(btn.Tag)]);
        //}
    }
}
