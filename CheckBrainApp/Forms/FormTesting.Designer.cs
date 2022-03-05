
namespace CheckBrainApp.Forms
{
    partial class FormTesting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTesting));
            this.btnTesting = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.panelTesting = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelAnswers = new System.Windows.Forms.Panel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnCancelTest = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.pnlQuestionsList = new System.Windows.Forms.Panel();
            this.scrollQuestions = new Guna.UI2.WinForms.Guna2HScrollBar();
            this.panelTesting.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTesting
            // 
            this.btnTesting.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTesting.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTesting.FlatAppearance.BorderSize = 0;
            this.btnTesting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTesting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTesting.Location = new System.Drawing.Point(380, 439);
            this.btnTesting.Name = "btnTesting";
            this.btnTesting.Size = new System.Drawing.Size(151, 43);
            this.btnTesting.TabIndex = 1;
            this.btnTesting.Text = "Начать тестирование";
            this.btnTesting.UseVisualStyleBackColor = false;
            this.btnTesting.Click += new System.EventHandler(this.btnTestingOnClick);
            // 
            // lblMain
            // 
            this.lblMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMain.Location = new System.Drawing.Point(201, 160);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(474, 175);
            this.lblMain.TabIndex = 2;
            this.lblMain.Text = resources.GetString("lblMain.Text");
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTesting
            // 
            this.panelTesting.Controls.Add(this.lblTime);
            this.panelTesting.Controls.Add(this.lblInfo);
            this.panelTesting.Controls.Add(this.lblTotal);
            this.panelTesting.Controls.Add(this.panelAnswers);
            this.panelTesting.Controls.Add(this.lblQuestion);
            this.panelTesting.Controls.Add(this.btnCancelTest);
            this.panelTesting.Controls.Add(this.btnAnswer);
            this.panelTesting.Location = new System.Drawing.Point(99, 96);
            this.panelTesting.Name = "panelTesting";
            this.panelTesting.Size = new System.Drawing.Size(693, 408);
            this.panelTesting.TabIndex = 3;
            this.panelTesting.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.Location = new System.Drawing.Point(492, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(133, 20);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Время на ответ:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(3, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(87, 20);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Вопрос № ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblTotal.Location = new System.Drawing.Point(205, 50);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(184, 25);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "ТекстРезультата";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotal.Visible = false;
            // 
            // panelAnswers
            // 
            this.panelAnswers.Location = new System.Drawing.Point(0, 128);
            this.panelAnswers.Name = "panelAnswers";
            this.panelAnswers.Size = new System.Drawing.Size(693, 230);
            this.panelAnswers.TabIndex = 4;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblQuestion.Location = new System.Drawing.Point(45, 50);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(154, 25);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "ТекстВопроса";
            // 
            // btnCancelTest
            // 
            this.btnCancelTest.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelTest.FlatAppearance.BorderSize = 0;
            this.btnCancelTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancelTest.ForeColor = System.Drawing.Color.White;
            this.btnCancelTest.Location = new System.Drawing.Point(3, 364);
            this.btnCancelTest.Name = "btnCancelTest";
            this.btnCancelTest.Size = new System.Drawing.Size(130, 40);
            this.btnCancelTest.TabIndex = 2;
            this.btnCancelTest.Text = "Закрыть тест";
            this.btnCancelTest.UseVisualStyleBackColor = false;
            this.btnCancelTest.Click += new System.EventHandler(this.btnCancelTest_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAnswer.FlatAppearance.BorderSize = 0;
            this.btnAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswer.ForeColor = System.Drawing.Color.White;
            this.btnAnswer.Location = new System.Drawing.Point(560, 364);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(130, 40);
            this.btnAnswer.TabIndex = 0;
            this.btnAnswer.Text = "Ответ";
            this.btnAnswer.UseVisualStyleBackColor = false;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // timerTest
            // 
            this.timerTest.Tick += new System.EventHandler(this.timerTest_Tick);
            // 
            // pnlQuestionsList
            // 
            this.pnlQuestionsList.BackColor = System.Drawing.SystemColors.Control;
            this.pnlQuestionsList.Location = new System.Drawing.Point(0, 0);
            this.pnlQuestionsList.Name = "pnlQuestionsList";
            this.pnlQuestionsList.Size = new System.Drawing.Size(879, 78);
            this.pnlQuestionsList.TabIndex = 5;
            this.pnlQuestionsList.Visible = false;
            // 
            // scrollQuestions
            // 
            this.scrollQuestions.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.scrollQuestions.HighlightOnWheel = true;
            this.scrollQuestions.HoverState.Parent = null;
            this.scrollQuestions.LargeChange = 10;
            this.scrollQuestions.Location = new System.Drawing.Point(0, 518);
            this.scrollQuestions.MouseWheelBarPartitions = 1;
            this.scrollQuestions.Name = "scrollQuestions";
            this.scrollQuestions.PressedState.Parent = this.scrollQuestions;
            this.scrollQuestions.ScrollbarSize = 13;
            this.scrollQuestions.Size = new System.Drawing.Size(876, 13);
            this.scrollQuestions.TabIndex = 6;
            this.scrollQuestions.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.scrollQuestions.Visible = false;
            // 
            // FormTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 543);
            this.ControlBox = false;
            this.Controls.Add(this.scrollQuestions);
            this.Controls.Add(this.pnlQuestionsList);
            this.Controls.Add(this.panelTesting);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.btnTesting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTesting";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Tag = "ТЕСТИРОВАНИЕ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTesting_FormClosing);
            this.Load += new System.EventHandler(this.FormTestingOnLoad);
            this.panelTesting.ResumeLayout(false);
            this.panelTesting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTesting;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Panel panelTesting;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnCancelTest;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Panel panelAnswers;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerTest;
        private System.Windows.Forms.Panel pnlQuestionsList;
        private Guna.UI2.WinForms.Guna2HScrollBar scrollQuestions;
    }
}