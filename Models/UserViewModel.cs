using System;

namespace gamingWebshop.Models
{
    public class UserViewModel
    {
        public long UserId { get; set; }

        public string FirstName {get; set;}

        public string LastName {get; set;}

        public string Email {get; set;}

        public string Password {get; set;}

        public long ShoppingCartFk {get; set;}
    }
}