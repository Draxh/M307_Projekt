 
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gamingWebshop.Models;

namespace gamingWebshop.Controllers
{
    public class TeamController : Controller
    {
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

    public IActionResult GenG()
    {
        return View();
    }

    public IActionResult Astralis()
    {
        return View();
    }

    }
}