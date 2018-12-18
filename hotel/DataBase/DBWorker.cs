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
                                 IdCard = customerdb.IdCard == null ? 0 : customerdb.IdCard,
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

        public static Customer FindCustomerById(int id)
        {
            using (MyDBContext context = new MyDBContext())
            {
                return context.Customer.Find(id);
            }
        }

        public static void InsertCard(DiscountCard discountCard, int idCustomer)
        {
            using (MyDBContext context = new MyDBContext())
            {
                Customer customer = context.Customer.Find(idCustomer);
                if (customer != null && customer.IdCard == null)
                {
                    context.DiscountCard.Add(discountCard);
                    customer.IdCard = discountCard.IdCard;
                    context.Update(customer);
                    context.SaveChanges();
                }
            }
        }

        public static void InsertCustomer(Customer customer)
        {
            using (MyDBContext context = new MyDBContext())
            {
                context.Customer.Add(customer);
                context.SaveChanges();
            }
        }

        public static void UpdateCard(int? idCard, int discount)
        {
            using (MyDBContext context = new MyDBContext())
            {
                DiscountCard discountCard = context.DiscountCard.Find(idCard);
                discountCard.Discount = discount;
                context.Update(discountCard);
                context.SaveChanges();
            }
        }


        public static string GetLastCustomer()
        {
            string secondName = "";
            using (MyDBContext context = new MyDBContext())
            {
                Customer customer = context.Customer.LastOrDefault();
                secondName += customer.SecondName;
            }
            return secondName;
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

        public static string GenerateCardNumber()
        {
            int card = 1234567890;

            using (MyDBContext context = new MyDBContext())
            {
                DiscountCard discountCard = context.DiscountCard.LastOrDefault();
                if (discountCard == null)
                {
                    return card.ToString();
                }
                else
                {
                    card += discountCard.IdCard;
                    return card.ToString();
                }
            }
        }

        public static void SearchRoom(int capacity, string type)
        {
            List<Reserving> resrvings = new List<Reserving>();
            List<Room> rooms = new List<Room>();
            using (MyDBContext context = new MyDBContext())
            {
                resrvings = context.Reserving.ToList();
                var types = (from typedb in context.TypeRoom
                             where typedb.Categoria.ToLower() == type.ToLower()
                             select new TypeRoom()
                             {
                                 IdType = typedb.IdType,
                                 Categoria = typedb.Categoria,
                                 Rooms = (from roomdb in context.Room
                                          where roomdb.Capacity == capacity
                                          select roomdb).ToList()
                             }).ToList();
                foreach(Reserving reserv in resrvings)
                {
                    foreach(TypeRoom type1 in types)
                    {
                        if(reserv.IdRoom == type1.Rooms[0].IdRoom)
                        {

                        }
                    }
                }
                
            }

        }

    }
}


