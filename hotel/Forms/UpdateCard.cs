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
    public partial class UpdateCard : Form
    {
        private DiscountCard newDiscountCard;
        public UpdateCard(DiscountCard discountCard)
        {
            InitializeComponent();
            newDiscountCard = discountCard;
            numberCardLabel.Text = newDiscountCard.NumberCard;
            comboBoxDiscount.Text = newDiscountCard.Discount.ToString();
            string[] discount = new string[] { "3", "10", "15", "20" };
            comboBoxDiscount.Items.AddRange(discount);           
        }

        private void UpdateDiscount_Click(object sender, EventArgs e)
        {
            //DiscountCard discountCard = new DiscountCard();
            int discount = Convert.ToInt32(comboBoxDiscount.Text);
            DBWorker.UpdateCard(newDiscountCard.IdCard, discount);
            this.Hide();
            MessageBox.Show("Данные были обновленны", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
