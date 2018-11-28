using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using hotel.DataBase;
using hotel.Forms;

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
            //DBWorker.GetDBConnection();
            //DBWorker.Name();
            // Console.Read();
             Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new Form2());
           // DBWorker.Nam();

        }  
    }
}
