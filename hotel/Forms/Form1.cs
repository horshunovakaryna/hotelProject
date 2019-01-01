using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hotel;
using hotel.Component;
using hotel.DataBase;

namespace hotel.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkIn(object sender, EventArgs e)
        {
            this.Hide();
            CheckIn checkInForm = new CheckIn();
            checkInForm.ShowDialog();
        }

        private void bookClick(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void cancelBook(object sender, EventArgs e)
        {
            this.Hide();
            CancelBook cancelBook = new CancelBook();
            cancelBook.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CloseApplication(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
