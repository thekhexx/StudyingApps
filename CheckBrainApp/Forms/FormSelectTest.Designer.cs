
namespace CheckBrainApp.Forms
{
    partial class FormSelectTest
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
            this.btnFrist = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnThird = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSecond = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMain = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelButtons.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFrist
            // 
            this.btnFrist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFrist.FlatAppearance.BorderSize = 0;
            this.btnFrist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFrist.Location = new System.Drawing.Point(0, 0);
            this.btnFrist.Name = "btnFrist";
            this.btnFrist.Size = new System.Drawing.Size(242, 50);
            this.btnFrist.TabIndex = 0;
            this.btnFrist.Text = "Первый раздел";
            this.btnFrist.UseVisualStyleBackColor = true;
            this.btnFrist.Click += new System.EventHandler(this.btnFrist_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnAll);
            this.panelButtons.Controls.Add(this.panel1);
            this.panelButtons.Controls.Add(this.btnThird);
            this.panelButtons.Controls.Add(this.panel3);
            this.panelButtons.Controls.Add(this.btnSecond);
            this.panelButtons.Controls.Add(this.panel2);
            this.panelButtons.Controls.Add(this.btnFrist);
            this.panelButtons.Location = new System.Drawing.Point(45, 46);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(242, 300);
            this.panelButtons.TabIndex = 1;
            // 
            // btnThird
            // 
            this.btnThird.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThird.FlatAppearance.BorderSize = 0;
            this.btnThird.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnThird.Location = new System.Drawing.Point(0, 120);
            this.btnThird.Name = "btnThird";
            this.btnThird.Size = new System.Drawing.Size(242, 50);
            this.btnThird.TabIndex = 4;
            this.btnThird.Text = "Третий раздел";
            this.btnThird.UseVisualStyleBackColor = true;
            this.btnThird.Click += new System.EventHandler(this.btnThird_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 10);
            this.panel3.TabIndex = 3;
            // 
            // btnSecond
            // 
            this.btnSecond.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSecond.FlatAppearance.BorderSize = 0;
            this.btnSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnSecond.Location = new System.Drawing.Point(0, 60);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(242, 50);
            this.btnSecond.TabIndex = 2;
            this.btnSecond.Text = "Второй раздел";
            this.btnSecond.UseVisualStyleBackColor = true;
            this.btnSecond.Click += new System.EventHandler(this.btnSecond_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblMain);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 40);
            this.panel4.TabIndex = 2;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMain.Location = new System.Drawing.Point(33, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(267, 24);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Выберите один из разделов";
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnCancel.Location = new System.Drawing.Point(0, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(333, 31);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Назад";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAll
            // 
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnAll.Location = new System.Drawing.Point(0, 180);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(242, 50);
            this.btnAll.TabIndex = 6;
            this.btnAll.Text = "По всем разделам";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 10);
            this.panel1.TabIndex = 5;
            // 
            // FormSelectTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 383);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSelectTest";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSelectTest";
            this.Load += new System.EventHandler(this.FormSelectTest_Load);
            this.panelButtons.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFrist;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnThird;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSecond;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Panel panel1;
    }
}