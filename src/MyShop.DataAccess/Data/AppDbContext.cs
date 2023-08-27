using Microsoft.EntityFrameworkCore;
using MyShop.Domain.Entities.Categories;
using MyShop.Domain.Entities.Companies;
using MyShop.Domain.Entities.Customers;
using MyShop.Domain.Entities.Orders;
using MyShop.Domain.Entities.Products;
using MyShop.Domain.Entities.Shippers;
using MyShop.Domain.Entities.Suppliers;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace MyShop.Service.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Company> Companies { get; set; }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<OrderDetails> OrderDetails { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<Shipper> Shippers { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        AddData(modelBuilder);
    }

    public void AddData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Company>().HasData
            (
                new Company()
                {
                    Id = 1,
                    Name = "MyShop",
                    PhoneNumber = "+998944396669",
                    Description = "Onile shop",
                    ImagePath = "",
                }
            );
        modelBuilder.Entity<Category>().HasData
            (
                 new Category()
                 {
                     Id = 1,
                     Name = "Clothes",
                     Description = "Clothing is any item worn on the body",
                     ImagePath = "",
                 }
            );
        modelBuilder.Entity<Product>().HasData
            (
                new Product()
                {
                    Id = 1,
                    Name = "Shim",
                    ImagePath = "",
                    Price = 99900,
                    Description = "Kush uchun mo'ljallangan shimlar"

                },
                new Product()
                {
                    Id = 2,
                    Name = "Ko'ylak",
                    ImagePath = "",
                    Price = 199900,
                    Description = "Ipak tolalaridan tayyorlangan :)"
                },
                new Product()
                {
                    Id = 3,
                    Name = "Kastyum",
                    ImagePath = "",
                    Price = 799900,
                    Description = "O'quvchilar uchun ajoyib tanlov"
                }
            );
    }
}