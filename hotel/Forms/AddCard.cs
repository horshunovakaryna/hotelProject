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
    public partial class AddCard : Form
    {
        private Customer newCustomer;
        public AddCard(Customer customer)
        {
            InitializeComponent();
            newCustomer = customer;
            label3.Text = newCustomer.SecondName;
            label6.Text = newCustomer.FirstName;
            cardNumberText.Text = DBWorker.GenerateCardNumber();
            chooseDiscount.Text = "Выберите скидку";
            string[] discount = new string[] { "3", "10", "15", "20"};
            chooseDiscount.Items.AddRange(discount);
           
        }

        private void addNewCard_Click(object sender, EventArgs e)
        {
            int type = chooseDiscount.SelectedIndex;
            if (type == -1)
            {
                MessageBox.Show("Чтобы продолжить, выберите сикдку", "Сообщение", MessageBoxButtons.OK);
            }
            else{
                DiscountCard discountCard = new DiscountCard();
                discountCard.NumberCard = cardNumberText.Text;
                discountCard.Discount = Convert.ToInt32(chooseDiscount.Text);
                DBWorker.InsertCard(discountCard, newCustomer.IdCustomer);
                this.Hide();
                MessageBox.Show("Дисконтная карта добавленна", "Сообщение", MessageBoxButtons.OK);
            }
           
            
        }

        private void AddCard_Load(object sender, EventArgs e)
        {

        }
    }
}
