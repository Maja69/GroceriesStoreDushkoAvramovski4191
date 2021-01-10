using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceriesStore.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {

        }
        public DbSet<Groceries> Groceries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Apples" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Bananas" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Oranges" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Grapes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Tomato" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 6, CategoryName = "Strawberry" });



            modelBuilder.Entity<Groceries>().HasData(new Groceries
            {
                GroceriesId = 1,
                Name = "Yellow Banana",
                Price = 50M,
                Description = "Nice Yellow Banana",
                CategoryId = 2,
                ImageUrl = "\\Images\\banana.jpg",
                ImageThumbnailUrl="\\Images\\banana.jpg",
                IsOnStock = true,
                IsOnSale = false
            }) ;
            modelBuilder.Entity<Groceries>().HasData(new Groceries
            {
                GroceriesId = 2,
                Name = "Green Banana",
                Price = 40M,
                Description = "Nice Green Banana",
                CategoryId = 2,
                ImageUrl = "\\Images\\greenbanana.jpg",
                ImageThumbnailUrl = "\\Images\\greenbanana.jpg",
                IsOnStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Groceries>().HasData(new Groceries
            {
                GroceriesId = 3,
                Name = "Red Apple",
                Price = 30M,
                Description = "Nice Red Apple",
                CategoryId = 1,
                ImageUrl = "\\Images\\redapple.jpg",
                ImageThumbnailUrl = "\\Images\\redapple.jpg",
                IsOnStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Groceries>().HasData(new Groceries
            {
                GroceriesId = 4,
                Name = "Yellow Apple",
                Price = 35M,
                Description = "Nice Yellow Apple",
                CategoryId = 1,
                ImageUrl = "\\Images\\yellowapple.jpg",
                ImageThumbnailUrl="\\Images\\yellowapple.jpg",
                IsOnStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Groceries>().HasData(new Groceries
            {
                GroceriesId = 5,
                Name = "Green Apple",
                Price = 50M,
                Description = "Nice Green Apple",
                CategoryId = 1,
                ImageUrl = "\\Images\\greenapple.jpg",
                ImageThumbnailUrl = "\\Images\\greenapple.jpg",
                IsOnStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Groceries>().HasData(new Groceries
            {
                GroceriesId = 6,
                Name = "Orange",
                Price = 54M,
                Description = "Nice Orange",
                CategoryId = 3,
                ImageUrl = "\\Images\\orange.jpg",
                ImageThumbnailUrl = "\\Images\\orange.jpg",
                IsOnStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Groceries>().HasData(new Groceries
            {
                GroceriesId = 7,
                Name = "Red Orange",
                Price = 75M,
                Description = "Nice Red Orange",
                CategoryId = 3,
                ImageUrl = "\\Images\\redorange.jpg",
                ImageThumbnailUrl = "\\Images\\redorange.jpg",
                IsOnStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Groceries>().HasData(new Groceries
            {
                GroceriesId = 8,
                Name = "Mandarina",
                Price = 100M,
                Description = "Nice Mandarina",
                CategoryId = 3,
                ImageUrl = "\\Images\\mandarina.jpg",
                ImageThumbnailUrl = "\\Images\\mandarina.jpg",
                IsOnStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Groceries>().HasData(new Groceries
            {
                GroceriesId = 9,
                Name = "Grape",
                Price = 100M,
                Description = "Nice Grape",
                CategoryId = 4,
                ImageUrl = "\\Images\\grape.jpg",
                ImageThumbnailUrl = "\\Images\\grape.jpg",
                IsOnStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Groceries>().HasData(new Groceries
            {
                GroceriesId = 10,
                Name = "Red Grape",
                Price = 100M,
                Description = "Nice Red Grape",
                CategoryId = 4,
                ImageUrl = "\\Images\\redgrape.jpg",
                ImageThumbnailUrl = "\\Images\\redgrape.jpg",
                IsOnStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Groceries>().HasData(new Groceries
            {
                GroceriesId = 11,
                Name = "Yellow Grape",
                Price = 110M,
                Description = "Nice Yellow Grape",
                CategoryId = 4,
                ImageUrl = "\\Images\\yellowgrape.jpg",
                ImageThumbnailUrl = "\\Images\\yellowgrape.jpg",
                IsOnStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Groceries>().HasData(new Groceries
            {
                GroceriesId = 12,
                Name = "Tomato",
                Price = 150M,
                Description = "Nice Tomato",
                CategoryId = 5,
                ImageUrl = "\\Images\\tomato.jpg",
                ImageThumbnailUrl = "\\Images\\tomato.jpg",
                IsOnStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Groceries>().HasData(new Groceries
            {
                GroceriesId = 13,
                Name = "Strawberry",
                Price = 250M,
                Description = "Nice Red Strawberry",
                CategoryId = 6,
                ImageUrl = "\\Images\\strawberry.jpg",
                ImageThumbnailUrl = "\\Images\\strawberry.jpg",
                IsOnStock = true,
                IsOnSale = false
            });
        }
    }
}
