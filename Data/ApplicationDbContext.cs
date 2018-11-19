using System;
using System.Collections.Generic;
using System.Text;
using gamingWebshop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bogus;

namespace gamingWebshop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Product> Products {get; set; }
        public DbSet<Category> Categories {get; set; }
        public DbSet<ShoppingCart> ShoppingCarts {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var productsIds = 1;
            var testProduct = new Faker<Product>()
                .RuleFor(p => p.ProductId, () => productsIds++)
                .RuleFor(p => p.ProductName, f => f.Lorem.Slug(8))
                .RuleFor(p => p.Description, f => f.Lorem.Slug(8))
                .RuleFor(p => p.Price,(8));

            var categoryIds = 1;
            var testCategory = new Faker<Category>()
                .RuleFor(c => c.CategoryId, () => categoryIds++)
                .RuleFor(c => c.CategoryName, f => f.Lorem.Slug(8));

            var userIds = 1;
            var testUser = new Faker<User>()
                .RuleFor(u => u.UserId, () => userIds++)
                .RuleFor(u => u.FirstName, f => f.Lorem.Slug(8))
                .RuleFor(u => u.LastName, f => f.Lorem.Slug(8));

            var shoppingcartIds = 1;
            var testShoppingCart = new Faker<ShoppingCart>()
                .RuleFor(s => s.ShoppingCartId, () => shoppingcartIds++);

            var products = new List<dynamic>();
            var categories = new List<dynamic>();
            var users = new List<dynamic>();
            var shoppingcarts = new List<dynamic>();

            var rnd = new Random();

            foreach(var product in testProduct.Generate(20))
            {
                products.Add(new
                {
                    CategoryId = (Int64) rnd.Next(1, categoryIds),
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Description = product.Description,
                    Price = product.Price
                });
            }

            foreach(var category in testCategory.Generate(3))
            {
                categories.Add(new
                {
                    CategoryId = category.CategoryId,
                    CategoryName = category.CategoryName
                });
            }

             foreach(var user in testUser.Generate(0))
            {
                users.Add(new
                {
                    UserId = user.UserId,
                    FirstName = user.FirstName,
                    Lastname = user.LastName,
                    
                });
            }

            foreach(var shoppingcart in testShoppingCart.Generate(20))
            {
                shoppingcarts.Add(new
                {
                    ShoppingCartId = shoppingcart.ShoppingCartId
                });
            }

            modelBuilder.Entity<Product>().HasData(products.ToArray());
            modelBuilder.Entity<Category>().HasData(categories.ToArray());
            modelBuilder.Entity<User>().HasData(users.ToArray());
            modelBuilder.Entity<ShoppingCart>().HasData(shoppingcarts.ToArray());
        }
    }
}
