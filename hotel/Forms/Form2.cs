using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hotel.Component;
using hotel.DataBase;

namespace hotel.Forms
{
    public partial class Form2 : Form
    {

        public Form2()
        {
               InitializeComponent();
            dataGridView2.Columns.AddRange(
       new DataGridViewTextBoxColumn() { Name = "clmFirstName", HeaderText = "Имя", DataPropertyName = "firstname", },
       new DataGridViewTextBoxColumn() { Name = "clmSecondName", HeaderText = "Фамилия", DataPropertyName = "secondname"},
       new DataGridViewTextBoxColumn() { Name = "clmPassport", HeaderText = "Паспортные данные", DataPropertyName = "passportinformation"},
       new DataGridViewTextBoxColumn() { Name = "clmCardNumber", HeaderText = "Номер карты", DataPropertyName = "numbercard" },
       new DataGridViewTextBoxColumn() { Name = "clmDiscount", HeaderText = "Скидка", DataPropertyName = "discount" });
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.White;
            comboBox1.Text = "Выберите категорию";
            string[] category = new string[] { "Эконом", "Стандарт", "Полуюкс", "Люкс", "Президентский номер" };
            comboBox1.Items.AddRange(category);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            List<Customer> customers = new List<Customer>();
            customers = DBWorker.SelectCustomer(textBox3.Text);
            int? id;
            foreach (Customer cust in customers)
            {
                if (cust.id_card == null)
                {
                    dataGridView2.Rows.Add(cust.FirstName, cust.SecondName, cust.PassportInformation,
                   "-", "-");
                }
                else
                {
                    id = cust.id_card;
                    dataGridView2.Rows.Add(
                        cust.FirstName, 
                        cust.SecondName, 
                        cust.PassportInformation, 
                        cust.DiscountCard.NumberCard, 
                        cust.DiscountCard.Discount + "%"
                        );
                }
            }
            dataGridView2.ClearSelection();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Information inform = new Information();
            inform.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
