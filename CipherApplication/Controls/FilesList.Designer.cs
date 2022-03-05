
namespace CipherApplication.Controls
{
    partial class FilesList
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FIleName = new System.Windows.Forms.Label();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FIleName
            // 
            this.FIleName.AutoSize = true;
            this.FIleName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIleName.Location = new System.Drawing.Point(3, 151);
            this.FIleName.Name = "FIleName";
            this.FIleName.Size = new System.Drawing.Size(52, 23);
            this.FIleName.TabIndex = 3;
            this.FIleName.Text = "Name";
            // 
            // ImagePanel
            // 
            this.ImagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImagePanel.Location = new System.Drawing.Point(0, 0);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(190, 151);
            this.ImagePanel.TabIndex = 1;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.WeightLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(132, 151);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(58, 23);
            this.WeightLabel.TabIndex = 2;
            this.WeightLabel.Text = "Weight";
            // 
            // FilesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.ImagePanel);
            this.Controls.Add(this.FIleName);
            this.Name = "FilesList";
            this.Size = new System.Drawing.Size(190, 177);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FIleName;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.Label WeightLabel;
    }
}
