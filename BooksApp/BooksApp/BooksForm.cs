using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksApp
{
    public partial class BooksForm : Form
    {
        List<Book> books = new List<Book>();
        BooksData data = new BooksData();
        
        public BooksForm()
        {
            InitializeComponent();
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            try
            {
                books = data.GetBooks();
                LoadBooks();
                LocalizeToRussian();
                UpdateBookCount();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void LoadBooks()
        {
            
            
            booksGridView.DataSource = books.ToList();
        }

        public void LocalizeToRussian()
        {
            booksGridView.Columns[0].HeaderText = "Фамилия" ;
            booksGridView.Columns[1].HeaderText = "Имя";
            booksGridView.Columns[2].HeaderText = "Отчество";
            booksGridView.Columns[3].HeaderText = "Название";
            booksGridView.Columns[4].HeaderText = "Город";
            booksGridView.Columns[5].HeaderText = "Издательство";
            booksGridView.Columns[6].HeaderText = "Год выпуска";
        }

        public void UpdateBookCount()
        {
            int count = books.Where(b => Convert.ToInt32(b.Year) > 2010).Count();
            lblCount.Text = "Количество книг, выпущенных за последние 10 лет:" + count.ToString();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            booksGridView.DataSource = books.Where(b=>b.BookName.ToLower().Contains(tbSearch.Text.ToLower())).ToList();

        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            Book book = new Book { BookName = "", Address = "", Name = "", Patronymic = "", Publisher = "", Surname = "", Year = "" };
            books.Add(book);
            LoadBooks();
        }

        private void CheckBooksAndSave()
        {
            bool saveIt = true;
            foreach (DataGridViewRow row in booksGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (String.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        MessageBox.Show("Имеются незаполненные ячейки!");
                        saveIt = false;
                        break;
                    }
                }
            }
            if (saveIt)
            {
                data.SaveBooks(books);
                UpdateBookCount();
                MessageBox.Show("Данные успешно сохранены");
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            CheckBooksAndSave();
            
            
            
        }
    }
}
