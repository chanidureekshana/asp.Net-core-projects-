using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ECommerce.Data
{
    public class AppDbContext : IdentityDbContext<UserModel>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ecommerce.db");
        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<CartItemModel> CartItems { get; set; }
        public DbSet<CartModel> Carts { get; set; }
        // public DbSet<OrderItemModel> OrderItems { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        // public DbSet<OrderModel> Orders { get; set; }
        // public DbSet<PaymentModel> Payments { get; set; }
        public DbSet<ProductModel> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships
            modelBuilder.Entity<UserModel>()
                .HasMany(u => u.Cart)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // modelBuilder.Entity<UserModel>()
            //     // .HasMany(u => u.Orders)
            //     .WithOne(o => o.User)
            //     .HasForeignKey(o => o.UserId)
            //     .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CartModel>()
                .HasMany(c => c.CartItems)
                .WithOne(ci => ci.Cart)
                .HasForeignKey(ci => ci.CartId);
            // modelBuilder.Entity<OrderModel>()
            //     .HasMany(o => o.OrderItems)   // Navigation property in OrderModel
            //     .WithOne(oi => oi.Order)      // Navigation property in OrderItemModel
            //     .HasForeignKey(oi => oi.OrderId) // Foreign key in OrderItemModel
            //     .OnDelete(DeleteBehavior.Cascade); // Optional: Cascade delete

            // modelBuilder.Entity<OrderModel>()
            //     .HasOne(o => o.Payment)
            //     .WithOne(p => p.Order)
            //     .HasForeignKey<PaymentModel>(p => p.OrderId);

            modelBuilder.Entity<ProductModel>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
