using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.Component
{
    public class Customer
    {
        public int IdCustomer { get; set; }
        public int? IdCard { get; set; }
        public DiscountCard DiscountCard { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string PassportInformation { get; set; } 

        override
        public String ToString()
        {
            return IdCustomer +FirstName + SecondName;
        }
    }

    public class DiscountCard
    {
        public int IdCard { get; set; }
        public string NumberCard { get; set; }
        public int Discount { get; set; }
    }

    public class Room
    {
        public int IdRoom { get; set; }
        public int IdType { get; set; }
        public int Capacity { get; set; }
        public int NumberOfRoom { get; set; }
    }

    public class Reserving
    {
        public int IdReserving { get; set; }
        public int IdCustomer { get; set; }
        public Customer Customer { get; set; }
        public int IdRoom { get; set; }
        public Room Room { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public bool Active { get; set; }
    }

    public class TypeRoom
    {
        public int IdType { get; set; }
        public string Categoria { get; set; }
        public float Price { get; set; }
    }

}
