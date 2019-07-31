using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ElectronicStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ElectronicStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);

        }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductAttributes> ProductAttributes { get; set; }
        public DbSet<ApplicationUsers> ApplicationUsers { get; set; }
        public DbSet<OrderBills> Orders { get; set; }
        public DbSet<ProductSelectedForBill> ProductSelectedForOrders { get; set; }
        public DbSet<Coupons> Coupons { get; set; }
        public DbSet<ShipperAssignedForOrder> ShipperAssignedForOrders { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
    }
}
