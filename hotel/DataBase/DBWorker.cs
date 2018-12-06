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

            using (MyDBContext context = new MyDBContext())
            {
                Customer customer = new Customer();
                var query = (from customerdb in context.Customer
                             where customerdb.SecondName.ToLower().Contains(secondName.ToLower())
                             join discountdb in context.DiscountCard
                             on customerdb.id_card equals discountdb.IdCard into disc
                             from d in disc.DefaultIfEmpty()
                             select new Customer()
                             {
                                 IdCustomer = customerdb.IdCustomer,
                                 FirstName = customerdb.FirstName,
                                 SecondName = customerdb.SecondName,
                                 PassportInformation = customerdb.PassportInformation,
                                 id_card = customerdb.id_card == null? null:customerdb.id_card,
                                  DiscountCard =
                                  new DiscountCard()
                                  {
                                      IdCard = d.IdCard == null ? 0 : d.IdCard,
                                      NumberCard = d.NumberCard == null ? " " : d.NumberCard,
                                      Discount = d.Discount == null ? 0 : d.Discount
                                  }
                             }).ToList();
                foreach (Customer cust in query)
                {
                    customers.Add(cust);
                    Console.WriteLine(cust.DiscountCard);
                }
                    
            }
            return customers;
        }
        /* List<Customer> customers = new List<Customer>();
         Customer customer = new Customer();
         using (MyDBContext context = new MyDBContext())
         {
             var query = (from customerdb in context.Customer
                          where customerdb.SecondName.ToLower().Contains(secondName.ToLower())
                          select customerdb).ToList();

             foreach (Customer cust in query)
                 customers.Add(cust);
         }
         return customers;*/


        /*public static JoinCustomer SelectCustomerCard(int? id)
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
        }*/

        /*public static void InsertCard(string card, float discountValue)
        {
            DiscountCard card1 = new DiscountCard();
            using (MyDBContext context = new MyDBContext())
            {

                card1.NumberCard = card;
                card1.Discount = discountValue;

                context.Add(card);
                context.SaveChanges();
            /
        }*/
    }
}

