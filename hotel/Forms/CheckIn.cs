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
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchBox.Text;        
            FillGrid(searchText);
            checkInBookViev.ClearSelection();
        }

        private void FillGrid(string searchText)
        {
            checkInBookViev.Rows.Clear();
            List<Reserving> reservings = new List<Reserving>();
            reservings = DBWorker.SelectReserving(searchText);
            foreach (Reserving reserv in reservings)
            {
                if(reserv.CheckIn.Date == DateTime.Today)
                {
                    TimeSpan t = reserv.CheckOut - reserv.CheckIn;
                    int night = Convert.ToInt32(t.TotalDays);
                    checkInBookViev.Rows.Add(
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
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            int id = GetSelectedReserv();
            DBWorker.UpdateReserving(id);
            MessageBox.Show("Клиент поселен!", "Сообщение", MessageBoxButtons.OK);
            FillGrid(searchBox.Text);
        }

        private int GetSelectedReserv()
        {
            int id = 0;
            Int32 selectedRowCount = checkInBookViev.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                foreach (DataGridViewRow row in checkInBookViev.Rows)
                {
                    if (row.Selected)
                    {
                        id = (int)row.Cells[6].Value;
                    }
                }
            }
            return id;
        }
    }
}
