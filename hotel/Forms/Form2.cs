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
using hotel;

namespace hotel.Forms
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            dataGridView2.Columns.AddRange(
       new DataGridViewTextBoxColumn() { Name = "clmFirstName", HeaderText = "Имя", DataPropertyName = "firstname", },
       new DataGridViewTextBoxColumn() { Name = "clmSecondName", HeaderText = "Фамилия", DataPropertyName = "secondname" },
       new DataGridViewTextBoxColumn() { Name = "clmPassport", HeaderText = "Паспортные данные", DataPropertyName = "passportinformation" },
       new DataGridViewTextBoxColumn() { Name = "clmCardNumber", HeaderText = "Номер карты", DataPropertyName = "numbercard" },
       new DataGridViewTextBoxColumn() { Name = "clmDiscount", HeaderText = "Скидка", DataPropertyName = "discount" },
       new DataGridViewTextBoxColumn() { Name = "clmId", HeaderText = "ID", DataPropertyName = "id" },
       new DataGridViewTextBoxColumn() { Name = "clmIdCard", HeaderText = "IDCard", DataPropertyName = "idCard" });
            dataGridView2.Columns["clmId"].Visible = false;
            dataGridView2.Columns["clmIdCard"].Visible = false;

            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.White;
            comboBox1.Text = "Выберите категорию";
            string[] category = new string[] { "Эконом", "Стандарт", "Полуюкс", "Люкс", "Президентский номер" };
            comboBox1.Items.AddRange(category);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string searchText = textBox3.Text;
            FillGrid(searchText);
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

        private void button6_Click(object sender, EventArgs e)
        {

            this.Hide();
            AddCustomer addCard = new AddCustomer();
            addCard.ShowDialog();
            FillGrid(DBWorker.GetLastCustomer());
            this.Show();
        }

        private void addCard_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = GetSelectedCustomer();
            if (selectedCustomer.IdCustomer != 0)
            {
                if (!DBWorker.CheckCustomerCard(selectedCustomer.IdCustomer))
                {
                    MessageBox.Show("У клиента уже есть дисконтная карта", "Сообщение", MessageBoxButtons.OK);
                }
                else
                {
                    this.Hide();
                    AddCard addCard = new AddCard(selectedCustomer);
                    addCard.ShowDialog();
                    FillGrid(textBox3.Text);
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Выберите клиента");
            }

        }

        private Customer GetSelectedCustomer()
        {
            Customer customer = new Customer();
            Int32 selectedRowCount = dataGridView2.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Selected)
                    {
                        customer.IdCustomer = (int)row.Cells[5].Value;
                        customer.FirstName = (string)row.Cells[0].Value;
                        customer.SecondName = (string)row.Cells[1].Value;
                    }
                }
            }
            return customer;
        }

        private DiscountCard GetSelectedCard()
        {
            DiscountCard discountCard = new DiscountCard();
            Int32 selectedRowCount = dataGridView2.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Selected && (int)row.Cells[6].Value !=0)
                    {
                        discountCard.NumberCard = (string)row.Cells[3].Value;
                        discountCard.Discount = Convert.ToInt32(row.Cells[4].Value);
                        discountCard.IdCard = (int)row.Cells[6].Value;
                    }
                }
            }           
            return discountCard;
        }

        private void FillGrid(string searchText)
        {
            dataGridView2.Rows.Clear();
            List<Customer> customers = new List<Customer>();
            customers = DBWorker.SelectCustomer(searchText);
            foreach (Customer cust in customers)
            {
                if (cust.IdCard == 0)
                {
                    dataGridView2.Rows.Add(cust.FirstName, cust.SecondName, cust.PassportInformation,
                   "-", "-", cust.IdCustomer,0);
                }
                else
                {
                    dataGridView2.Rows.Add(
                    cust.FirstName,
                    cust.SecondName,
                    cust.PassportInformation,
                    cust.DiscountCard.NumberCard,
                    cust.DiscountCard.Discount,
                    cust.IdCustomer,
                    cust.IdCard
                        );
                }
            }
        }

        private void UpdateCard_Click(object sender, EventArgs e)
        {
            DiscountCard selectedCard = GetSelectedCard();
            if (selectedCard.IdCard != 0)
            {
                this.Hide();
                UpdateCard addCard = new UpdateCard(selectedCard);
                addCard.ShowDialog();
                FillGrid(textBox3.Text);
                this.Show();
            }
            else
            {
                MessageBox.Show("У клиента нет карты!");
            }
        }
        
    }
}
