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
       new DataGridViewTextBoxColumn() { Name = "clmName", HeaderText = "Имя", DataPropertyName = "firstname", Width=130},
       new DataGridViewTextBoxColumn() { Name = "clmAmount", HeaderText = "Фамилия", DataPropertyName = "secondname", Width = 143 });
            dataGridView2.AllowUserToAddRows = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            List<Customer> customers = new List<Customer>();
            customers = DBWorker.SelectCustomer(textBox3.Text);
            foreach (Customer cust in customers)
                dataGridView2.Rows.Add(cust.FirstName, cust.SecondName);
            if(customers.Count == 0)
            {
                dataGridView2.Rows.Clear();
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

    }
}
