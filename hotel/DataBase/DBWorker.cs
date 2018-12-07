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
        public static List<Customer> SelectCustomer(String secondName)
        {
            List<Customer> customers = new List<Customer>();

            using (MyDBContext context = new MyDBContext())
            {
                Customer customer = new Customer();
                var query = (from customerdb in context.Customer
                             where customerdb.SecondName.ToLower().Contains(secondName.ToLower())
                             join discountdb in context.DiscountCard
                             on customerdb.IdCard equals discountdb.IdCard into disc
                             from d in disc.DefaultIfEmpty()
                             select new Customer()
                             {
                                 IdCustomer = customerdb.IdCustomer,
                                 FirstName = customerdb.FirstName,
                                 SecondName = customerdb.SecondName,
                                 PassportInformation = customerdb.PassportInformation,
                                 IdCard = customerdb.IdCard == null ? null : customerdb.IdCard,
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

        public static void InsertCard(string numberCard, int discountValue, int idCustomer)
        {
            using (MyDBContext context = new MyDBContext())
            {
                Customer customer = context.Customer.Find(idCustomer);
                if (customer != null && customer.IdCard == null)
                {
                    DiscountCard card = new DiscountCard();
                    card.NumberCard = numberCard;
                    card.Discount = discountValue;
                    context.DiscountCard.Add(card);
                    customer.IdCard = card.IdCard;
                    context.Update(customer);
                    context.SaveChanges();
                }
            }
        }

        public static bool ValidateCardNumber(string cardNumber)
        {
            using (MyDBContext context = new MyDBContext())
            {
                var query = (from card in context.DiscountCard
                             select card).ToList();

                foreach (DiscountCard card in query) {
                    if (card.NumberCard == cardNumber)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool CheckCustomerCard(int id)
        {
            using (MyDBContext context = new MyDBContext())
            {
                Customer customer = context.Customer.Find(id);
                if (customer.IdCard != null)
                {
                    return false;
                }
            }
            return true;
        }
    }
    
}


