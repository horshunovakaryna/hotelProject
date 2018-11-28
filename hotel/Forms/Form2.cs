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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Customer> customers = new List<Customer>();
            customers = DBWorker.SelectCustomer(textBox3.Text);
            foreach (Customer cust in customers)
                dataGridView2.Columns.AddRange(
        new DataGridViewTextBoxColumn() { Name = "clmName", HeaderText = "Имя", DataPropertyName = "firstname" },
        new DataGridViewTextBoxColumn() { Name = "clmAmount", HeaderText = "Фамилия", DataPropertyName = "secondname" });
            dataGridView2.DataSource = customers;
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

    }
}
