using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.Component
{
    class Customer
    {
        public int IdCustomer { get; set; }
        public int? id_card { get; set; }
        public DiscountCard  DiscountCard { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string PassportInformation { get; set; } 

        override
        public String ToString()
        {
            return FirstName + SecondName;
        }
    }

    class DiscountCard
    {
        public int IdCard { get; set; }
        public string NumberCard { get; set; }
        public string Discount { get; set; }
    }

    class Employee
    {
        public int IdEmployee { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }

    class Room
    {
        public int IdRoom { get; set; }
        public int IdType { get; set; }
        public int Capacity { get; set; }
        public int NumberOfRoom { get; set; }
    }

    class JoinCustomer
    {
        public int IdCustomer { get; set; }
        public string CardNumber { get; set; }

        public JoinCustomer()
        {

        }
        public JoinCustomer(int id, string cardNumber)
        {
            this.IdCustomer = id;
            this.CardNumber = cardNumber;
        }
    }
}
