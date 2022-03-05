
namespace CipherApplication
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cipherButton = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ivBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.pickFileButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.IVCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.toolPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.settingsButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.minimizeButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.exitButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filesListView = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.extractFileButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.itemContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.extractCurrentFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.pickedFileLabel = new System.Windows.Forms.Label();
            this.toolPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.itemContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cipherButton
            // 
            this.cipherButton.BackColor = System.Drawing.Color.DarkGray;
            this.cipherButton.FlatAppearance.BorderSize = 0;
            this.cipherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cipherButton.Location = new System.Drawing.Point(96, 172);
            this.cipherButton.Name = "cipherButton";
            this.cipherButton.Size = new System.Drawing.Size(97, 23);
            this.cipherButton.TabIndex = 1;
            this.cipherButton.Text = "Enscrypt";
            this.cipherButton.UseVisualStyleBackColor = false;
            this.cipherButton.Click += new System.EventHandler(this.cipherButtonOnClick);
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(112, 83);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(240, 20);
            this.keyBox.TabIndex = 2;
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(81, 86);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(25, 13);
            this.keyLabel.TabIndex = 3;
            this.keyLabel.Text = "Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Initialization vector";
            // 
            // ivBox
            // 
            this.ivBox.Enabled = false;
            this.ivBox.Location = new System.Drawing.Point(112, 136);
            this.ivBox.Name = "ivBox";
            this.ivBox.Size = new System.Drawing.Size(240, 20);
            this.ivBox.TabIndex = 4;
            // 
            // outputTextBox
            // 
            this.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTextBox.Location = new System.Drawing.Point(12, 201);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(340, 263);
            this.outputTextBox.TabIndex = 6;
            // 
            // pickFileButton
            // 
            this.pickFileButton.BackColor = System.Drawing.Color.DarkGray;
            this.pickFileButton.FlatAppearance.BorderSize = 0;
            this.pickFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickFileButton.Location = new System.Drawing.Point(15, 172);
            this.pickFileButton.Name = "pickFileButton";
            this.pickFileButton.Size = new System.Drawing.Size(75, 23);
            this.pickFileButton.TabIndex = 7;
            this.pickFileButton.Text = "Pick file";
            this.pickFileButton.UseVisualStyleBackColor = false;
            this.pickFileButton.Click += new System.EventHandler(this.pickFileButtonOnClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(15, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.saveFileButtonOnClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(199, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Descrypt selected file";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.descryptFileButtonOnClick);
            // 
            // IVCheckBox
            // 
            this.IVCheckBox.AutoSize = true;
            this.IVCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IVCheckBox.CheckedState.BorderRadius = 2;
            this.IVCheckBox.CheckedState.BorderThickness = 0;
            this.IVCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IVCheckBox.Location = new System.Drawing.Point(112, 109);
            this.IVCheckBox.Name = "IVCheckBox";
            this.IVCheckBox.Size = new System.Drawing.Size(133, 17);
            this.IVCheckBox.TabIndex = 10;
            this.IVCheckBox.Text = "Set Initialization Vector";
            this.IVCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.IVCheckBox.UncheckedState.BorderRadius = 2;
            this.IVCheckBox.UncheckedState.BorderThickness = 0;
            this.IVCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.IVCheckBox.UseVisualStyleBackColor = true;
            this.IVCheckBox.CheckedChanged += new System.EventHandler(this.IVCheckBox_CheckedChanged);
            // 
            // toolPanel
            // 
            this.toolPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolPanel.Controls.Add(this.settingsButton);
            this.toolPanel.Controls.Add(this.minimizeButton);
            this.toolPanel.Controls.Add(this.exitButton);
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolPanel.Location = new System.Drawing.Point(0, 0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.ShadowDecoration.Parent = this.toolPanel;
            this.toolPanel.Size = new System.Drawing.Size(1087, 28);
            this.toolPanel.TabIndex = 11;
            this.toolPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolPanel_MouseDown);
            // 
            // settingsButton
            // 
            this.settingsButton.CheckedState.Parent = this.settingsButton;
            this.settingsButton.CustomImages.Parent = this.settingsButton;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsButton.FillColor = System.Drawing.Color.BlueViolet;
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.HoverState.Parent = this.settingsButton;
            this.settingsButton.Image = global::CipherApplication.Properties.Resources.settings;
            this.settingsButton.Location = new System.Drawing.Point(1003, 0);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.settingsButton.ShadowDecoration.Parent = this.settingsButton;
            this.settingsButton.Size = new System.Drawing.Size(28, 28);
            this.settingsButton.TabIndex = 14;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.CheckedState.Parent = this.minimizeButton;
            this.minimizeButton.CustomImages.Parent = this.minimizeButton;
            this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeButton.FillColor = System.Drawing.Color.BlueViolet;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.HoverState.Parent = this.minimizeButton;
            this.minimizeButton.Location = new System.Drawing.Point(1031, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.minimizeButton.ShadowDecoration.Parent = this.minimizeButton;
            this.minimizeButton.Size = new System.Drawing.Size(28, 28);
            this.minimizeButton.TabIndex = 13;
            this.minimizeButton.Text = "_";
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.CheckedState.Parent = this.exitButton;
            this.exitButton.CustomImages.Parent = this.exitButton;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.FillColor = System.Drawing.Color.BlueViolet;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.Location = new System.Drawing.Point(1059, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(28, 28);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.filesListView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(374, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 497);
            this.panel1.TabIndex = 12;
            // 
            // filesListView
            // 
            this.filesListView.HideSelection = false;
            this.filesListView.LargeImageList = this.iconList;
            this.filesListView.Location = new System.Drawing.Point(3, 38);
            this.filesListView.MultiSelect = false;
            this.filesListView.Name = "filesListView";
            this.filesListView.Size = new System.Drawing.Size(723, 447);
            this.filesListView.SmallImageList = this.iconList;
            this.filesListView.TabIndex = 1;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            this.filesListView.ItemActivate += new System.EventHandler(this.filesListView_ItemActivate);
            this.filesListView.SelectedIndexChanged += new System.EventHandler(this.filesListView_SelectedIndexChanged);
            this.filesListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filesListView_MouseClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "file.png");
            this.iconList.Images.SetKeyName(1, "lockFile.png");
            this.iconList.Images.SetKeyName(2, "musicFile.png");
            this.iconList.Images.SetKeyName(3, "pngFile.png");
            this.iconList.Images.SetKeyName(4, "txtFile.png");
            this.iconList.Images.SetKeyName(5, "videoFile.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.extractFileButton);
            this.panel2.Controls.Add(this.infoLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 32);
            this.panel2.TabIndex = 0;
            // 
            // extractFileButton
            // 
            this.extractFileButton.BackColor = System.Drawing.Color.DarkGray;
            this.extractFileButton.FlatAppearance.BorderSize = 0;
            this.extractFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extractFileButton.Location = new System.Drawing.Point(532, 6);
            this.extractFileButton.Name = "extractFileButton";
            this.extractFileButton.Size = new System.Drawing.Size(153, 23);
            this.extractFileButton.TabIndex = 13;
            this.extractFileButton.Text = "Extract all files";
            this.extractFileButton.UseVisualStyleBackColor = false;
            this.extractFileButton.Click += new System.EventHandler(this.extractFileButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.Location = new System.Drawing.Point(241, 6);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(224, 20);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Archive ciphed file system";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemContextMenu
            // 
            this.itemContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractCurrentFileButton});
            this.itemContextMenu.Name = "itemContextMenu";
            this.itemContextMenu.Size = new System.Drawing.Size(114, 26);
            // 
            // extractCurrentFileButton
            // 
            this.extractCurrentFileButton.Name = "extractCurrentFileButton";
            this.extractCurrentFileButton.Size = new System.Drawing.Size(113, 22);
            this.extractCurrentFileButton.Text = "Extract ";
            this.extractCurrentFileButton.Click += new System.EventHandler(this.extractCurrentFileButton_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(358, 31);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 486);
            this.guna2VSeparator1.TabIndex = 14;
            // 
            // pickedFileLabel
            // 
            this.pickedFileLabel.AutoSize = true;
            this.pickedFileLabel.Location = new System.Drawing.Point(9, 31);
            this.pickedFileLabel.Name = "pickedFileLabel";
            this.pickedFileLabel.Size = new System.Drawing.Size(80, 13);
            this.pickedFileLabel.TabIndex = 15;
            this.pickedFileLabel.Text = "No file selected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 525);
            this.Controls.Add(this.pickedFileLabel);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.IVCheckBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pickFileButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ivBox);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.cipherButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CipherApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.itemContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cipherButton;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ivBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button pickFileButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Guna.UI2.WinForms.Guna2CheckBox IVCheckBox;
        private Guna.UI2.WinForms.Guna2Panel toolPanel;
        private Guna.UI2.WinForms.Guna2CircleButton minimizeButton;
        private Guna.UI2.WinForms.Guna2CircleButton exitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label infoLabel;
        private Guna.UI2.WinForms.Guna2CircleButton settingsButton;
        private System.Windows.Forms.ListView filesListView;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Button extractFileButton;
        private System.Windows.Forms.ContextMenuStrip itemContextMenu;
        private System.Windows.Forms.ToolStripMenuItem extractCurrentFileButton;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.Label pickedFileLabel;
    }
}

