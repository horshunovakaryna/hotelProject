using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using hotel.DataBase;
using hotel.Forms;
using hotel.Component;

namespace hotel
{
    static class Program
    {       
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args) 
        {
            DateTime date1 = new DateTime(2018, 12, 20, 12, 01, 0);
            DateTime date2 = new DateTime(2018, 12, 22, 12, 0, 0);
            DBWorker.SearchRoom(2, "Эконом", date1, date2);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }  
    }
}
