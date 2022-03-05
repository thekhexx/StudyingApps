using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsApplication
{
    public partial class CarsForm : Form
    {
        List<Car> cars = new List<Car>();
        CarsSource data = new CarsSource();
        public CarsForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Car car = new Car { Model = "", Color = "", Number = "", OwnerSurname = "",  Year = "" };
            cars.Add(car);
            LoadCars();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            CheckCarsAndSave();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            carsGridView.DataSource = cars.Where(b => b.Year.ToLower().StartsWith(textBoxSearch.Text.ToLower())).ToList();
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            try
            {
                cars = data.LoadCars();
                LoadCars();
                LocalizeToRussian();
                UpdateCarCount();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadCars()
        {
            carsGridView.DataSource = cars.ToList();
        }
        private void CheckCarsAndSave()
        {
            bool saveIt = true;
            foreach (DataGridViewRow row in carsGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (String.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        MessageBox.Show("Заполните все поля!");
                        saveIt = false;
                        break;
                    }
                }
            }
            if (saveIt)
            {
                data.SaveCars(cars);
                UpdateCarCount();
                MessageBox.Show("Сохранение прошло успешно!");
            }
        }
        public void LocalizeToRussian()
        {
            carsGridView.Columns[0].HeaderText = "Модель";
            carsGridView.Columns[1].HeaderText = "Цвет";
            carsGridView.Columns[2].HeaderText = "Фамилия владельца";
            carsGridView.Columns[3].HeaderText = "Номер";
            carsGridView.Columns[4].HeaderText = "Год выпуска";
        }
        public void UpdateCarCount()
        {
            int count = cars.Where(b => b.Color.StartsWith("С")).Count();
            labelCount.Text = "Количество машин, цвет которых начинается с буквы 'С':" + count.ToString();
        }

    }
}
