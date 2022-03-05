
namespace CheckBrainApp.Forms
{
    partial class FormTheory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTheory));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.webTheory = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(105, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ТЕОРИЯ ";
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMain.Location = new System.Drawing.Point(45, 110);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(772, 125);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = resources.GetString("lblMain.Text");
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelButtons
            // 
            this.panelButtons.Location = new System.Drawing.Point(304, 275);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(283, 194);
            this.panelButtons.TabIndex = 2;
            // 
            // webTheory
            // 
            this.webTheory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webTheory.Location = new System.Drawing.Point(0, 0);
            this.webTheory.MinimumSize = new System.Drawing.Size(20, 20);
            this.webTheory.Name = "webTheory";
            this.webTheory.Size = new System.Drawing.Size(878, 543);
            this.webTheory.TabIndex = 5;
            this.webTheory.Visible = false;
            // 
            // FormTheory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(878, 543);
            this.ControlBox = false;
            this.Controls.Add(this.webTheory);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTheory";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Tag = "ТЕОРИЯ";
            this.Load += new System.EventHandler(this.FormTheory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.WebBrowser webTheory;
    }
}