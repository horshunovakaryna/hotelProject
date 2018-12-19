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

        public static Room FindRoomById(int id)
        {
            using (MyDBContext context = new MyDBContext())
            {
                return context.Room.Find(id);
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

        public static void Resrving(Customer customer, Room room, DateTime date1, DateTime date2, bool active)
        {
            using (MyDBContext context = new MyDBContext())
            {
                Reserving reserving = new Reserving();
                reserving.IdCustomer = customer.IdCustomer;
                reserving.IdRoom = room.IdRoom;
                reserving.CheckIn = date1;
                reserving.CheckOut = date2;
                reserving.Active = active;
                context.Reserving.Add(reserving);
                context.SaveChanges();
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

        public static List<Room> SearchRoom(int capacity, string type, DateTime checkIn, DateTime checkOut)
        {
            List<Reserving> reservings = new List<Reserving>();
            List<Room> availableRooms = new List<Room>();
            using (MyDBContext context = new MyDBContext())
            {
                reservings = context.Reserving.ToList();
                var rooms = (from roomdb in context.Room
                             where roomdb.Capacity >= capacity
                             && roomdb.TypeRoom.Categoria == type
                             join typedb in context.TypeRoom on
                             roomdb.IdType equals typedb.IdType
                             select new Room()
                             {
                                 IdRoom = roomdb.IdRoom,
                                 Capacity = roomdb.Capacity,
                                 NumberOfRoom = roomdb.NumberOfRoom,
                                 Price = roomdb.Price,
                                 TypeRoom = new TypeRoom()
                                 {
                                     IdType = typedb.IdType,
                                     Categoria = typedb.Categoria
                                 }


                             }).ToList();

                foreach (Room room in rooms)
                {
                    bool roomIsBooked = RoomIsBooked(room, reservings, checkIn, checkOut);
                    if (roomIsBooked)
                    {
                        availableRooms.Add(room);
                    }
                }
            }
            return availableRooms;
        }

        private static bool RoomIsBooked(Room room, List<Reserving> reservings, DateTime checkIn, DateTime checkOut)
        {
            foreach (Reserving reserving in reservings)
            {
                if (reserving.IdRoom == room.IdRoom &&
                    (reserving.CheckIn >= checkIn && reserving.CheckOut <= checkOut)
                    ||
                    reserving.IdRoom == room.IdRoom &&
                    (reserving.CheckIn < checkIn && checkIn < reserving.CheckOut))
                {
                    return false;
                }
            }
            return true;
        }

        public static void RemoveCustomer(Customer customer)
        {
            using (MyDBContext context = new MyDBContext())
            {
                context.Customer.Remove(customer);
                context.SaveChanges();
            }
        }
    }
}




  



