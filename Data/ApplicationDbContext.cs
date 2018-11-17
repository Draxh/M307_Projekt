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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var productsIds = 1;
            var testProduct = new Faker<Product>()
                .RuleFor(prod => prod.ProductId, () => productsIds++)
                .RuleFor(prod => prod.ProductName, f => f.Lorem.Slug(8))
                .RuleFor(prod => prod.Description, f => f.Lorem.Slug(8))
                .RuleFor(prod => prod.Price,(8));

            var categoryIds = 1;
            var testCategory = new Faker<Category>()
                .RuleFor(prod => prod.CategoryId, () => categoryIds++)
                .RuleFor(prod => prod.CategoryName, f => f.Lorem.Slug(8));

            var products = new List<dynamic>();
            var categories = new List<dynamic>();

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
                products.Add(new
                {
                    CategoryId = category.CategoryId,
                    CategoryName = category.CategoryName
                });
            }

            modelBuilder.Entity<Product>().HasData(products.ToArray());
            modelBuilder.Entity<Category>().HasData(categories.ToArray());
        }

    }
}
