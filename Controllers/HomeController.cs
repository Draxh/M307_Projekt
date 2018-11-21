using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gamingWebshop.Models;
using gamingWebshop.Data;

namespace gamingWebshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        /* public ActionResult Index(){
            var products = _context.Categories.Include(a => a.Tasks);

            return null;
        }*/

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Gear()
        {
            return View();
        }

        public IActionResult Sales()
        {
            return View();
        }

        public IActionResult Clothes()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
