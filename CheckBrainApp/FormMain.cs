using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBrainApp
{
    public partial class FormMain : Form
    {
        //Поля 
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public FormMain()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Методы
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index) {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color,-0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }  
            }
        }
        private void OpenChildPanel(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            childForm.BringToFront();
            lblTitle.Text = childForm.Tag.ToString();
            childForm.Show();
            

        }

        private void btnTheory_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new Forms.FormTheory(),sender);
        }

        private void btnTesting_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new Forms.FormTesting(), sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new Forms.FormSettings(), sender);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new Forms.FormAbout(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "ГЛАВНАЯ";
            panelTitleBar.BackColor = Color.FromArgb(0,150,136);
            panelLogo.BackColor = Color.FromArgb(39,39,58);
            currentButton = null;
            btnCloseChildForm.Visible = false;


        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
             this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Forms.SplashScreen form = new Forms.SplashScreen();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
            else
            {
                Application.Exit();
            }
            
        }

        private void btnGoTesting_Click(object sender, EventArgs e)
        {
            btnTesting_Click(btnTesting, null);
        }

        private void btnGoTheory_Click(object sender, EventArgs e)
        {
            btnTheory_Click(btnTheory, null);
        }

        private void btnGoSetting_Click(object sender, EventArgs e)
        {
            btnSettings_Click(btnSettings, null);
        }

        private void btnGoAbout_Click(object sender, EventArgs e)
        {
            btnAbout_Click(btnAbout, null);
        }
    }
}
