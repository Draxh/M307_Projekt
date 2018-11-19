using System;
using Microsoft.AspNetCore.Identity;

namespace gamingWebshop.Models
{
    public class User : IdentityUser
    {
        public long UserId {get; set;}
        public string FirstName {get; set;}

        public string LastName {get; set;}

        public string Password {get; set;}

        public ShoppingCart ShoppingCart {get; set;}
    }
}