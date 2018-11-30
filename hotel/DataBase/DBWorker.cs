﻿using System;
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

        public static void Nam()
        {
            using (MyDBContext context = new MyDBContext())
            {
                var query = (from customerdb in context.Customer
                             where customerdb.SecondName == "test"
                             select customerdb).ToList();

                foreach (Customer cust in query)
                        Console.WriteLine($"{cust.FirstName} {cust.SecondName}");
            }
        }

        public static List<Customer> SelectCustomer(String secondName)
        {
            List<Customer> customers = new List<Customer>();
            Customer customer = new Customer();
            using (MyDBContext context = new MyDBContext())
            {
                var query = (from customerdb in context.Customer
                             where customerdb.SecondName.ToLower().Contains(secondName.ToLower())
                             select customerdb).ToList();

                foreach (Customer cust in query)
                    customers.Add(cust);
            }
            return customers;
        }

        public static JoinCustomer SelectCustomerCard(int? id)
        {
            JoinCustomer joinCustomer = new JoinCustomer();
            using (MyDBContext context = new MyDBContext())
            {
                var query = (from customerdb in context.Customer
                             join discountdb in context.DiscountCard
                             on customerdb.id_card equals discountdb.IdCard
                             where customerdb.IdCustomer == id
                             select new { customerdb.IdCustomer, discountdb.NumberCard, discountdb.Discount }).Single();
                joinCustomer.IdCustomer = query.IdCustomer;
                joinCustomer.CardNumber = query.NumberCard;
                joinCustomer.Discount = query.Discount;
            }
            
            return joinCustomer;
        }
    }
}
