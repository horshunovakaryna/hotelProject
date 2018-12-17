using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hotel.DataBase;
using hotel.Component;

namespace hotel.Forms
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FirstName = firstNameText.Text;
            customer.SecondName = secondNameText.Text;
            customer.PassportInformation = passportText.Text;
            DBWorker.InsertCustomer(customer);
            this.Hide();
            MessageBox.Show("Новый клиент добавленн", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
