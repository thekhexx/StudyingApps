
namespace BooksApp
{
    partial class BooksForm
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
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.booksGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(13, 350);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(126, 39);
            this.btnAddRow.TabIndex = 1;
            this.btnAddRow.Text = "Добавить книгу";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(13, 395);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(126, 43);
            this.btnSaveChanges.TabIndex = 2;
            this.btnSaveChanges.Text = "Сохранить изменения";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(496, 349);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(292, 20);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(383, 352);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(107, 13);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Поиск по названию";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(386, 395);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(273, 13);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "Количество книг, выпущенных за последние 10 лет:";
            // 
            // booksGridView
            // 
            this.booksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGridView.Location = new System.Drawing.Point(13, 12);
            this.booksGridView.Name = "booksGridView";
            this.booksGridView.Size = new System.Drawing.Size(775, 305);
            this.booksGridView.TabIndex = 6;
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.booksGridView);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnAddRow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книги";
            this.Load += new System.EventHandler(this.BooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView booksGridView;
    }
}

