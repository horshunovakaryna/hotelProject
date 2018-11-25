using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using hotel.Component;

namespace hotel.DataBase
{
    class DBWorker
    {
        
        public static void Name()
        {
            using (MyDBContext context = new MyDBContext())
            {
                var query = (from employee in context.Employee where employee.IdEmployee == 1 select employee).ToList();

                foreach (Employee emp in query)
                    Console.WriteLine($"{emp.FirstName} {emp.SecondName}");

                Console.ReadLine();
            }
        }

        public List<Customer> SelectCustomer(String secondName)
        {
            List<Customer> customers = new List<Customer>();
            Customer customer = new Customer();
            using (MyDBContext context = new MyDBContext())
            {
                var query = (from customerdb in context.Customer
                             where customerdb.SecondName == secondName
                             select customerdb).ToList();

                foreach (Customer cust in query)
                    customers.Add(cust);
            }
            return customers;
        }
    }
}
