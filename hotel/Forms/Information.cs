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
    public partial class Information : Form
    {
        private Customer newCustomer;
        private Room newRoom;
        private DateTime date1;
        private DateTime date2;

        public Information(Customer customer, DateTime date1, DateTime date2, Room room)
        {
            InitializeComponent();
            this.newCustomer = customer;
            this.newRoom = room;
            this.date1 = date1;
            this.date2 = date2;
            TimeSpan t = date2 - date1;
            int night = Convert.ToInt32(t.TotalDays);
            label28.Text = customer.FirstName;
            label29.Text = customer.SecondName;
            label30.Text = customer.PassportInformation;
            //label33.Text = customer.DiscountCard.NumberCard != "" ?
         //       customer.DiscountCard.NumberCard : "-";
            label1.Text = date1.ToString();
            label2.Text = date2.ToString();
            label3.Text = "№" + room.NumberOfRoom.ToString();
            label32.Text = (night * room.Price).ToString();
            label31.Text = night.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool active = false;
            if (date1.Date == DateTime.Today) active = true;
            DBWorker.Resrving(newCustomer, newRoom, date1, date2, active);
            this.Hide();
            MessageBox.Show("Номер забронирован", "Сообщение", MessageBoxButtons.OK);

        }
    }
}
