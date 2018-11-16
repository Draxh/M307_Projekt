using System;

namespace gamingWebshop.Models
{
    public class Product
    {
        public long ProductId { get; set; }

        public double Price {get; set; }

        public string Description {get; set; }

        public string ProductName {get; set;}

        public Category Category {get; set; }
    }
}