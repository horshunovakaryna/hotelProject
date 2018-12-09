using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//using MySql.Data.EntityFrameworkCore.Extensions;
//using MySql.Data.Entity;
using hotel.Component;

namespace hotel.DataBase
{

    class MyDBContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<DiscountCard> DiscountCard { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Reserving> Reserving { get; set; }
        public DbSet<TypeRoom> TypeRoom { get; set; }

        public MyDBContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=hotel;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>();
            modelBuilder.Entity<DiscountCard>();
            modelBuilder.Entity<Room>();
            modelBuilder.Entity<Reserving>();
            modelBuilder.Entity<TypeRoom>();

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.IdCustomer);
                entity.Property(e => e.FirstName).IsRequired();
                entity.Property(e => e.SecondName).IsRequired();
                entity.Property(e => e.PassportInformation).IsRequired();             
            });

            modelBuilder.Entity<DiscountCard>(entity =>
            {          
                entity.HasKey(e => e.IdCard);     
                entity.Property(e => e.NumberCard).IsRequired();
                entity.Property(e => e.Discount).IsRequired();
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => e.IdRoom);                
                entity.Property(e => e.IdType).IsRequired();
                entity.Property(e => e.Capacity).IsRequired();
                entity.Property(e => e.NumberOfRoom).IsRequired();
            });

            modelBuilder.Entity<Reserving>(entity =>
            {
                entity.HasKey(e => e.IdReserving);
                entity.Property(e => e.IdCustomer).IsRequired();
                entity.Property(e => e.IdRoom).IsRequired();
                entity.Property(e => e.CheckIn).IsRequired();
                entity.Property(e => e.CheckOut).IsRequired();
                entity.Property(e => e.Active).IsRequired();
            });

            modelBuilder.Entity<TypeRoom>(entity =>
            {
                entity.HasKey(e => e.IdType);               
                entity.Property(e => e.Categoria).IsRequired();
                entity.Property(e => e.Price).IsRequired();
            });
        }
    }
}

