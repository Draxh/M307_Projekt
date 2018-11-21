 
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
    public class TeamController : Controller
    {
    private readonly ApplicationDbContext _context;

    public TeamController(ApplicationDbContext context)
        {
            _context = context;
        }
    public IActionResult Fnatic()
    {
        return View();
    }

    public IActionResult Cloud9()
    {
        return View();
    } 

    public IActionResult TSM()
    {
        return View();
    }

    public IActionResult SKTT1()
    {
        return View();
    }

    public IActionResult Astralis()
    {
        return View();
    }

    }
}