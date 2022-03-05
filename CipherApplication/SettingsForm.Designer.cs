
namespace CipherApplication
{
    partial class SettingsForm
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
            this.toolPanel = new System.Windows.Forms.Panel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.setArchivePathButton = new System.Windows.Forms.Button();
            this.saveAndExitButton = new System.Windows.Forms.Button();
            this.cancelAndExitButton = new System.Windows.Forms.Button();
            this.applyChangesButton = new System.Windows.Forms.Button();
            this.extractPathLabel = new System.Windows.Forms.Label();
            this.setExtractPathButton = new System.Windows.Forms.Button();
            this.extractTextBox = new System.Windows.Forms.TextBox();
            this.toolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolPanel
            // 
            this.toolPanel.BackColor = System.Drawing.Color.DarkGray;
            this.toolPanel.Controls.Add(this.infoLabel);
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolPanel.Location = new System.Drawing.Point(0, 0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(378, 37);
            this.toolPanel.TabIndex = 0;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.Location = new System.Drawing.Point(146, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(68, 20);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Settings";
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directoryLabel.Location = new System.Drawing.Point(12, 84);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(128, 20);
            this.directoryLabel.TabIndex = 2;
            this.directoryLabel.Text = "Set archive path:";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(150, 84);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.ReadOnly = true;
            this.pathTextBox.Size = new System.Drawing.Size(216, 20);
            this.pathTextBox.TabIndex = 3;
            // 
            // setArchivePathButton
            // 
            this.setArchivePathButton.BackColor = System.Drawing.Color.DarkGray;
            this.setArchivePathButton.FlatAppearance.BorderSize = 0;
            this.setArchivePathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setArchivePathButton.Location = new System.Drawing.Point(269, 110);
            this.setArchivePathButton.Name = "setArchivePathButton";
            this.setArchivePathButton.Size = new System.Drawing.Size(97, 23);
            this.setArchivePathButton.TabIndex = 4;
            this.setArchivePathButton.Text = "Set";
            this.setArchivePathButton.UseVisualStyleBackColor = false;
            this.setArchivePathButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // saveAndExitButton
            // 
            this.saveAndExitButton.BackColor = System.Drawing.Color.DarkGray;
            this.saveAndExitButton.FlatAppearance.BorderSize = 0;
            this.saveAndExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAndExitButton.Location = new System.Drawing.Point(16, 415);
            this.saveAndExitButton.Name = "saveAndExitButton";
            this.saveAndExitButton.Size = new System.Drawing.Size(97, 23);
            this.saveAndExitButton.TabIndex = 5;
            this.saveAndExitButton.Text = "Save and exit";
            this.saveAndExitButton.UseVisualStyleBackColor = false;
            this.saveAndExitButton.Click += new System.EventHandler(this.saveAndExitButton_Click);
            // 
            // cancelAndExitButton
            // 
            this.cancelAndExitButton.BackColor = System.Drawing.Color.DarkGray;
            this.cancelAndExitButton.FlatAppearance.BorderSize = 0;
            this.cancelAndExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelAndExitButton.Location = new System.Drawing.Point(138, 415);
            this.cancelAndExitButton.Name = "cancelAndExitButton";
            this.cancelAndExitButton.Size = new System.Drawing.Size(97, 23);
            this.cancelAndExitButton.TabIndex = 6;
            this.cancelAndExitButton.Text = "Cancel and exit";
            this.cancelAndExitButton.UseVisualStyleBackColor = false;
            this.cancelAndExitButton.Click += new System.EventHandler(this.cancelAndExitButton_Click);
            // 
            // applyChangesButton
            // 
            this.applyChangesButton.BackColor = System.Drawing.Color.DarkGray;
            this.applyChangesButton.FlatAppearance.BorderSize = 0;
            this.applyChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyChangesButton.Location = new System.Drawing.Point(269, 415);
            this.applyChangesButton.Name = "applyChangesButton";
            this.applyChangesButton.Size = new System.Drawing.Size(97, 23);
            this.applyChangesButton.TabIndex = 7;
            this.applyChangesButton.Text = "Apply changes";
            this.applyChangesButton.UseVisualStyleBackColor = false;
            this.applyChangesButton.Click += new System.EventHandler(this.applyChangesButton_Click);
            // 
            // extractPathLabel
            // 
            this.extractPathLabel.AutoSize = true;
            this.extractPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extractPathLabel.Location = new System.Drawing.Point(12, 167);
            this.extractPathLabel.Name = "extractPathLabel";
            this.extractPathLabel.Size = new System.Drawing.Size(126, 20);
            this.extractPathLabel.TabIndex = 8;
            this.extractPathLabel.Text = "Set extract path:";
            // 
            // setExtractPathButton
            // 
            this.setExtractPathButton.BackColor = System.Drawing.Color.DarkGray;
            this.setExtractPathButton.FlatAppearance.BorderSize = 0;
            this.setExtractPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setExtractPathButton.Location = new System.Drawing.Point(263, 195);
            this.setExtractPathButton.Name = "setExtractPathButton";
            this.setExtractPathButton.Size = new System.Drawing.Size(97, 23);
            this.setExtractPathButton.TabIndex = 10;
            this.setExtractPathButton.Text = "Set";
            this.setExtractPathButton.UseVisualStyleBackColor = false;
            this.setExtractPathButton.Click += new System.EventHandler(this.setExtractPathButton_Click);
            // 
            // extractTextBox
            // 
            this.extractTextBox.Location = new System.Drawing.Point(144, 169);
            this.extractTextBox.Name = "extractTextBox";
            this.extractTextBox.ReadOnly = true;
            this.extractTextBox.Size = new System.Drawing.Size(216, 20);
            this.extractTextBox.TabIndex = 9;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 450);
            this.Controls.Add(this.setExtractPathButton);
            this.Controls.Add(this.extractTextBox);
            this.Controls.Add(this.extractPathLabel);
            this.Controls.Add(this.applyChangesButton);
            this.Controls.Add(this.cancelAndExitButton);
            this.Controls.Add(this.saveAndExitButton);
            this.Controls.Add(this.setArchivePathButton);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.directoryLabel);
            this.Controls.Add(this.toolPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.toolPanel.ResumeLayout(false);
            this.toolPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button setArchivePathButton;
        private System.Windows.Forms.Button saveAndExitButton;
        private System.Windows.Forms.Button cancelAndExitButton;
        private System.Windows.Forms.Button applyChangesButton;
        private System.Windows.Forms.Label extractPathLabel;
        private System.Windows.Forms.Button setExtractPathButton;
        private System.Windows.Forms.TextBox extractTextBox;
    }
}