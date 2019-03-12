using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Data
{
    public class InventoryDbContext : DbContext
    {
        const string connectionString = "Server=DESKTOP-OG4QADS;Database=Inventory;Trusted_Connection=True;";

        public InventoryDbContext() : base() { }

        public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options) { }

        
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<BillingAddress> BillingAddresses { get; set; }
        public DbSet<ShippingAddress> ShippingAddresses { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerRole> CustomerRoles { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<VatCategory> VatCategories { get; set; }
        public DbSet<TaxCategory> TaxCategories { get; set; }
        public DbSet<Vendor> vendors { get; set; }
        public DbSet<VendorNote> VendorNotes { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<LoginHistory> LoginHistories { get; set; }

        //public DbSet<Persion> Persions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Salary> Salaries { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}

