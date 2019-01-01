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
    public partial class CancelBook : Form
    {
        public CancelBook()
        {
            InitializeComponent();
        }

        private void buttonCancelBook_Click(object sender, EventArgs e)
        {
            Reserving selectedReserving = GetSelectedReserv();
            if (selectedReserving.IdReserving != 0)
            {
                DBWorker.RemoveReserv(selectedReserving);
            }
            else
            {
                MessageBox.Show("Выберите запись");
            }
            bookingViev.Rows.Clear();
            searchBox.Clear();
            MessageBox.Show("Бронь отменена!");
           
        }

        private Reserving GetSelectedReserv()
        {
            Reserving reserving = new Reserving();
            Int32 selectedRowCount = bookingViev.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                foreach (DataGridViewRow row in bookingViev.Rows)
                {
                    if (row.Selected)
                    {
                        reserving.IdReserving = (int)row.Cells[6].Value;
                    }
                }
            }
            return reserving;
        }

        private void FillGrid(string searchText)
        {
            bookingViev.Rows.Clear();
            List<Reserving> reservings = new List<Reserving>();
            reservings = DBWorker.SelectReserving(searchText);
            foreach (Reserving reserv in reservings)
            {
                    TimeSpan t = reserv.CheckOut - reserv.CheckIn;
                    int night = Convert.ToInt32(t.TotalDays);
                    bookingViev.Rows.Add(
                    reserv.Customer.FirstName,
                    reserv.Customer.SecondName,
                    reserv.Customer.PassportInformation,
                    reserv.CheckIn,
                    reserv.CheckOut,
                    night * reserv.Room.Price,
                    reserv.IdReserving
                    );
                }
        }

        private void searchButton1_Click(object sender, EventArgs e)
        {
            string searchText = searchBox.Text;
            FillGrid(searchText);
            bookingViev.ClearSelection();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void CloseApplication(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
