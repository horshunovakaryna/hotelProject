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
using System.Text.RegularExpressions;

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
            if (CheckRequiredData() && CheckCorrectData())
            {
                Customer customer = new Customer();
                customer.FirstName = firstNameText.Text;
                customer.SecondName = secondNameText.Text;
                customer.PassportInformation = passportText.Text;
                DBWorker.InsertCustomer(customer);
                this.Hide();
                MessageBox.Show("Новый клиент добавленн", 
                    "Сообщение", MessageBoxButtons.OK);
            }
        }

        private bool CheckRequiredData()
        {
            if(firstNameText.Text.Length == 0 || secondNameText.Text.Length == 0
                || passportText.Text.Length == 0)
            {
                MessageBox.Show("Чтобы продолжить, заполните все поля",
                    "Сообщение", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private bool CheckCorrectData()
        {
            string pattern = @"^[а-яА-ЯёЁa-zA-Z]+$";
            if (Regex.IsMatch(firstNameText.Text, pattern, RegexOptions.IgnoreCase)
                && Regex.IsMatch(secondNameText.Text, pattern, RegexOptions.IgnoreCase))
            {             
                return true;
            }
            MessageBox.Show("Для ввода имени и фамилии используйте только буквы", 
                "Сообщение", MessageBoxButtons.OK);
            return false;
        }
    }
}
