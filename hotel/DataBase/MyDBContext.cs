using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;
using MySql.Data.Entity;
using hotel.Component;

namespace hotel.DataBase
{

    class MyDBContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<DiscountCard> DiscountCard { get; set; }
        public DbSet<Room> Room { get; set; }

        public MyDBContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=hotel;user=root;password=root");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee);
                entity.Property(e => e.IdEmployee).IsRequired().HasColumnName("id_employee");
                entity.Property(e => e.FirstName).IsRequired().HasColumnName("first_name");
                entity.Property(e => e.SecondName).IsRequired().HasColumnName("second_name");
                entity.Property(e => e.Login).IsRequired().HasColumnName("login");
                entity.Property(e => e.Password).IsRequired().HasColumnName("password");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.IdCustomer);
                entity.Property(e => e.IdCustomer).IsRequired().HasColumnName("id_customer");
                entity.HasOne(f => f.DiscountCard).WithOne().HasForeignKey("id_card");
                //entity.Property(e => e.IdCard).HasColumnName("id_card");
                entity.Property(e => e.FirstName).IsRequired().HasColumnName("first_name");
                entity.Property(e => e.SecondName).IsRequired().HasColumnName("second_name");
                entity.Property(e => e.PassportInformation).IsRequired().HasColumnName("passport_information");             
            });

            modelBuilder.Entity<DiscountCard>(entity =>
            {
                entity.HasKey(e => e.IdCard);
                entity.Property(e => e.IdCard).IsRequired().HasColumnName("id_card");
                entity.Property(e => e.NumberCard).IsRequired().HasColumnName("number_card");
                entity.Property(e => e.Discount).IsRequired().HasColumnName("discount");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => e.IdRoom);
                entity.Property(e => e.IdRoom).IsRequired().HasColumnName("id_room");
                entity.Property(e => e.IdType).IsRequired().HasColumnName("id_type");
                entity.Property(e => e.Capacity).IsRequired().HasColumnName("capacity");
                entity.Property(e => e.NumberOfRoom).IsRequired().HasColumnName("room");
            });     
        }
    }
}

