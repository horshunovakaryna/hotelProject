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
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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

        private void UpdateCard_Click(object sender, EventArgs e)
        {
            DiscountCard selectedCard = GetSelectedCard();
            if (selectedCard.IdCard != 0)
            {
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkDate())
            {
                if (checkFillingBoxes())
                {
                    UpdateList();
                }
            }
        }

        private void dateCheckIn_ValueChanged(object sender, EventArgs e)
        {
            if (checkDate())
            {
                if (checkFillingBoxes())
                {
                    UpdateList();
                }
            }
        }

        private void dateCheckOut_ValueChanged(object sender, EventArgs e)
        {
            if (checkDate())
            {
                if (checkFillingBoxes())
                {
                    UpdateList();
                }
            }
            else
            {
                MessageBox.Show("Даты выбранны некорректно!");
            }
        }

        private void numericCapacity_ValueChanged(object sender, EventArgs e)
        {
            if (checkDate())
            {
                if (checkFillingBoxes())
                {
                    UpdateList();
                }
            }
        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = GetSelectedCustomer();
            if (selectedCustomer.IdCustomer != 0)
            {
                DBWorker.RemoveCustomer(selectedCustomer);
            }
            else
            {
                MessageBox.Show("Выберите клиента");
            }
            dataGridView2.Rows.Clear();
            textBox3.Clear();
            MessageBox.Show("Клиент удален!");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string searchText = textBox3.Text;
            FillGrid(searchText);
            dataGridView2.ClearSelection();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            AddCustomer addCard = new AddCustomer();
            addCard.ShowDialog();
            FillGrid(DBWorker.GetLastCustomer());
            this.Show();
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = GetSelectedCustomer();
            int id = GetSelectedRoom();
            Room room = DBWorker.FindRoomById(id);
            if (selectedCustomer.IdCustomer != 0)
            {
                if (id != 0)
                {
                    DateTime date1 = Convert.ToDateTime(dateCheckIn.Text + "13:00:00");
                    DateTime date2 = Convert.ToDateTime(dateCheckOut.Text + "12:00:00");
                    int capacity = (int)numericCapacity.Value;
                    Information inform = new Information(selectedCustomer, date1, date2, room);
                    inform.ShowDialog();
                    availableRoomGrid.Rows.Clear();
                    numericCapacity.Value = 1;
                    comboBox1.Text = "Выберите категорию";
                    dateCheckIn.Value = DateTime.Today;
                    dateCheckOut.Value = DateTime.Today.AddDays(1);
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Чтобы продолжить, выберите комнату");
                }
            }
            else
            {
                MessageBox.Show("Чтобы продолжить, выберите клиента");
            }
        }

        private Customer GetSelectedCustomer()
        {
            DataGridViewRow row = dataGridView2.CurrentRow;
            Customer customer = new Customer();

            if (row != null)
            {
                customer = DBWorker.FindCustomerById((int)row.Cells[5].Value);
                Console.WriteLine("meo "+customer.DiscountCard.NumberCard);
                /*customer.IdCustomer = (int)row.Cells[5].Value;
                customer.FirstName = (string)row.Cells[0].Value;
                customer.SecondName = (string)row.Cells[1].Value;
                customer.DiscountCard.NumberCard = (string)row.Cells[3].Value;
                customer.DiscountCard.Discount = (int)row.Cells[4].Value;
                customer.PassportInformation = (string)row.Cells[2].Value;*/
            }

            /*Int32 selectedRowCount = dataGridView2.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Selected)
                    {
                        customer.IdCustomer = (int)row.Cells[5].Value;
                        customer.FirstName = (string)row.Cells[0].Value;
                        customer.SecondName = (string)row.Cells[1].Value;
                        customer.DiscountCard.NumberCard = (string)row.Cells[3].Value;
                        customer.DiscountCard.Discount = (int)row.Cells[4].Value;
                        customer.PassportInformation = (string)row.Cells[2].Value;
                    }
                }
            }*/
            return customer;
        }

        private int GetSelectedRoom()
        {
            int id = 0;
            Int32 selectedRowCount = availableRoomGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                foreach (DataGridViewRow row in availableRoomGrid.Rows)
                {
                    if (row.Selected)
                    {
                        id = (int)row.Cells[1].Value;
                    }
                }
            }
            return id;
        }

        private DiscountCard GetSelectedCard()
        {
            DiscountCard discountCard = new DiscountCard();
            Int32 selectedRowCount = dataGridView2.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Selected && (int)row.Cells[6].Value != 0)
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
            List<Customer> customers = DBWorker.SelectCustomer(searchText);
            foreach (Customer cust in customers)
            {
                if (cust.IdCard == 0)
                {
                    dataGridView2.Rows.Add(cust.FirstName, cust.SecondName, cust.PassportInformation,
                   "-", "-", cust.IdCustomer, 0);
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

        private bool checkDate()
        {
            DateTime date1 = Convert.ToDateTime(dateCheckIn.Text + "13:00:00");
            DateTime date2 = Convert.ToDateTime(dateCheckOut.Text + "12:00:00");
            if (date1 >= date2 || date1 <= DateTime.Today || date2 < DateTime.Today)
            {
                dateCheckOut.Value = dateCheckIn.Value.AddDays(1);
                return false;
            }
            return true;
        }

        private bool checkFillingBoxes()
        {
            int capacity = (int)numericCapacity.Value;
            int type = comboBox1.SelectedIndex;
            if (type == -1 && capacity == 0)
            {
                return false;
            }
            return true;
        }

        private void UpdateList()
        {
            availableRoomGrid.ClearSelection();
            availableRoomGrid.Rows.Clear();
            DateTime date1 = Convert.ToDateTime(dateCheckIn.Text + "13:00:00");
            DateTime date2 = Convert.ToDateTime(dateCheckOut.Text + "12:00:00");
            int capacity = (int)numericCapacity.Value;
            string type = comboBox1.Text;
            List<Room> rooms = DBWorker.SearchRoom(capacity, type, date1, date2);
            foreach (Room room in rooms)
            {
                availableRoomGrid.Rows.Add(room.ToString(), room.IdRoom);
            }

        }

        private void CloseApplication(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
