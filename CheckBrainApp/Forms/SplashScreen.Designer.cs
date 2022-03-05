
namespace CheckBrainApp.Forms
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            this.progressBarLoading = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.progressBarLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Animated = true;
            this.progressBarLoading.Controls.Add(this.lblPercent);
            this.progressBarLoading.FillThickness = 7;
            this.progressBarLoading.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.progressBarLoading.Location = new System.Drawing.Point(35, 86);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.progressBarLoading.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressBarLoading.ShadowDecoration.Parent = this.progressBarLoading;
            this.progressBarLoading.Size = new System.Drawing.Size(210, 210);
            this.progressBarLoading.TabIndex = 1;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPercent.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPercent.Location = new System.Drawing.Point(70, 87);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(37, 41);
            this.lblPercent.TabIndex = 4;
            this.lblPercent.Text = "0";
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoading.ForeColor = System.Drawing.Color.White;
            this.lblLoading.Location = new System.Drawing.Point(86, 308);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(118, 24);
            this.lblLoading.TabIndex = 2;
            this.lblLoading.Text = "ЗАГРУЗКА";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(275, 72);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Обучающая программа\r\n\"Систематика, биология и экология \r\nпатогенных микроорганизм" +
    "ов и \r\nгрибов\"";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerLoading
            // 
            this.timerLoading.Enabled = true;
            this.timerLoading.Interval = 40;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(280, 350);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.progressBarLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.progressBarLoading.ResumeLayout(false);
            this.progressBarLoading.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressBarLoading;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.Label lblPercent;
    }
}