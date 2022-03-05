
namespace CheckBrainApp
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnTesting = new System.Windows.Forms.Button();
            this.btnTheory = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.btnGoAbout = new System.Windows.Forms.Button();
            this.btnGoSetting = new System.Windows.Forms.Button();
            this.btnGoTesting = new System.Windows.Forms.Button();
            this.btnGoTheory = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnAbout);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnTesting);
            this.panelMenu.Controls.Add(this.btnTheory);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 620);
            this.panelMenu.TabIndex = 0;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAbout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAbout.Location = new System.Drawing.Point(0, 195);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(220, 60);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "О программе";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.Location = new System.Drawing.Point(0, 560);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(220, 60);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Настройки";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Visible = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnTesting
            // 
            this.btnTesting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTesting.FlatAppearance.BorderSize = 0;
            this.btnTesting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTesting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTesting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTesting.Location = new System.Drawing.Point(0, 135);
            this.btnTesting.Name = "btnTesting";
            this.btnTesting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTesting.Size = new System.Drawing.Size(220, 60);
            this.btnTesting.TabIndex = 3;
            this.btnTesting.Text = "Пройти тестирование";
            this.btnTesting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTesting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTesting.UseVisualStyleBackColor = true;
            this.btnTesting.Click += new System.EventHandler(this.btnTesting_Click);
            // 
            // btnTheory
            // 
            this.btnTheory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTheory.FlatAppearance.BorderSize = 0;
            this.btnTheory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTheory.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTheory.Location = new System.Drawing.Point(0, 75);
            this.btnTheory.Name = "btnTheory";
            this.btnTheory.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTheory.Size = new System.Drawing.Size(220, 60);
            this.btnTheory.TabIndex = 2;
            this.btnTheory.Text = "Читать теорию";
            this.btnTheory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTheory.UseVisualStyleBackColor = true;
            this.btnTheory.Click += new System.EventHandler(this.btnTheory_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 75);
            this.panelLogo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Обучающая программа";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(880, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(826, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 30);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(850, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Х";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::CheckBrainApp.Properties.Resources.cancelIco;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 75);
            this.btnCloseChildForm.TabIndex = 3;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(402, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(99, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "ГЛАВНАЯ";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Controls.Add(this.btnGoAbout);
            this.panelDesktopPane.Controls.Add(this.btnGoSetting);
            this.panelDesktopPane.Controls.Add(this.btnGoTesting);
            this.panelDesktopPane.Controls.Add(this.btnGoTheory);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(220, 75);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(880, 545);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // btnGoAbout
            // 
            this.btnGoAbout.BackColor = System.Drawing.Color.Coral;
            this.btnGoAbout.FlatAppearance.BorderSize = 0;
            this.btnGoAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoAbout.Location = new System.Drawing.Point(443, 277);
            this.btnGoAbout.Name = "btnGoAbout";
            this.btnGoAbout.Size = new System.Drawing.Size(437, 268);
            this.btnGoAbout.TabIndex = 3;
            this.btnGoAbout.Text = "Перейти в раздел сведений о программе";
            this.btnGoAbout.UseVisualStyleBackColor = false;
            this.btnGoAbout.Click += new System.EventHandler(this.btnGoAbout_Click);
            // 
            // btnGoSetting
            // 
            this.btnGoSetting.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGoSetting.FlatAppearance.BorderSize = 0;
            this.btnGoSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoSetting.Location = new System.Drawing.Point(0, 277);
            this.btnGoSetting.Name = "btnGoSetting";
            this.btnGoSetting.Size = new System.Drawing.Size(447, 268);
            this.btnGoSetting.TabIndex = 2;
            this.btnGoSetting.Text = "Перейти в раздел настроек";
            this.btnGoSetting.UseVisualStyleBackColor = false;
            this.btnGoSetting.Click += new System.EventHandler(this.btnGoSetting_Click);
            // 
            // btnGoTesting
            // 
            this.btnGoTesting.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGoTesting.FlatAppearance.BorderSize = 0;
            this.btnGoTesting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoTesting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoTesting.Location = new System.Drawing.Point(443, 0);
            this.btnGoTesting.Name = "btnGoTesting";
            this.btnGoTesting.Size = new System.Drawing.Size(437, 278);
            this.btnGoTesting.TabIndex = 1;
            this.btnGoTesting.Text = "Перейти в раздел тестирования";
            this.btnGoTesting.UseVisualStyleBackColor = false;
            this.btnGoTesting.Click += new System.EventHandler(this.btnGoTesting_Click);
            // 
            // btnGoTheory
            // 
            this.btnGoTheory.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGoTheory.FlatAppearance.BorderSize = 0;
            this.btnGoTheory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoTheory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoTheory.Location = new System.Drawing.Point(0, 0);
            this.btnGoTheory.Name = "btnGoTheory";
            this.btnGoTheory.Size = new System.Drawing.Size(447, 278);
            this.btnGoTheory.TabIndex = 0;
            this.btnGoTheory.Text = "Перейти в раздел теории";
            this.btnGoTheory.UseVisualStyleBackColor = false;
            this.btnGoTheory.Click += new System.EventHandler(this.btnGoTheory_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 620);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 620);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 620);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnTheory;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnTesting;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGoAbout;
        private System.Windows.Forms.Button btnGoSetting;
        private System.Windows.Forms.Button btnGoTesting;
        private System.Windows.Forms.Button btnGoTheory;
    }
}

