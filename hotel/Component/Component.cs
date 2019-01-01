﻿using System;
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

        public List<Reserving> Reservings { get; set; }

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
        //public int IdType { get; set; }
        public int Capacity { get; set; }
        public int NumberOfRoom { get; set; }
        public double Price { get; set; }

        //override
       public String ToString()
        {
            return  "№"+NumberOfRoom +" "+Capacity+"-x местный " + TypeRoom.Categoria +
                " "+ Price.ToString() + "грн";
        }
        public int IdType { get; set; }
        public TypeRoom TypeRoom { get; set; }

        public List<Reserving> Reservings { get; set; }
    }

    public class Reserving
    {
        public int IdReserving { get; set; }
        //public int IdCustomer { get; set; }
       // public List<Customer> Customers { get; set; }
        //public int IdRoom { get; set; }
        
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public bool Active { get; set; }

        public int IdRoom { get; set; }
        public Room Room { get; set; }

        public int IdCustomer { get; set; }
        public Customer Customer { get; set; }

        public String ToString()
        {
            return "айди  " +IdReserving+ "Дата заезда " + CheckIn + "Дата выезда  " + CheckOut +
                "Статус " + Active;
        }

    }

    public class TypeRoom
    {
        public int IdType { get; set; }
        public string Categoria { get; set; }
       

        public List<Room> Rooms { get; set; }

        /*override
        public String ToString()
        {
            return IdType + Categoria +Rooms[0].ToString();
        }*/

    }

}
