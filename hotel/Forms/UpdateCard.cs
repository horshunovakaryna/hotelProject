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
        int[] availableDiscounts = new int[] { 3, 10, 15, 20 };

        private DiscountCard newDiscountCard;
        public UpdateCard(DiscountCard discountCard)
        {
            InitializeComponent();
            newDiscountCard = discountCard;
            numberCardLabel.Text = newDiscountCard.NumberCard;
            comboBoxDiscount.Text = newDiscountCard.Discount.ToString();

            int index = Array.IndexOf(availableDiscounts, newDiscountCard.Discount);
            int[] customerDiscount = new int[availableDiscounts.Length - index];
            Array.Copy(
                availableDiscounts,
                index,
                customerDiscount, 0, availableDiscounts.Length - index);

            comboBoxDiscount.Items.AddRange(customerDiscount.Select(d => d.ToString()).ToArray());        
        }

        private void UpdateDiscount_Click(object sender, EventArgs e)
        {           
            int discount = Convert.ToInt32(comboBoxDiscount.Text);
            DBWorker.UpdateCard(newDiscountCard.IdCard, discount);
            this.Hide();
            MessageBox.Show("Данные были обновленны", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
