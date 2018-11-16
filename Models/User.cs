using System;
using Microsoft.AspNetCore.Identity;

namespace gamingWebshop.Models
{
    public class User : IdentityUser
    {
        public string FirstName {get; set;}

        public string LastName {get; set;}

        public string Password {get; set;}

        public long ShoppingCartFk {get; set;}
    }
}