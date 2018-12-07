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
    public partial class AddCard : Form
    {
        public AddCard()
        {
            InitializeComponent();
            cardNumberText.Text = AdditionFunction.GenerateCardNumber();
            chooseDiscount.Text = "Выберите скидку";
            string[] discount = new string[] { "3%", "10%", "15%", "20%"};
            chooseDiscount.Items.AddRange(discount);
            newCardNumber.Hide();
        }

        private void addNewCard_Click(object sender, EventArgs e)
        {
            if (!DBWorker.ValidateCardNumber(cardNumberText.Text))
            {
                errorProvider1.SetError(cardNumberText, "Такая карта существует");
                newCardNumber.Show();
            }
        }

        private void newCardNumber_Click(object sender, EventArgs e)
        {
            cardNumberText.Text = AdditionFunction.GenerateCardNumber();
            errorProvider1.Clear();
            newCardNumber.Hide();
        }

        private void AddCard_Load(object sender, EventArgs e)
        {

        }
    }
}
