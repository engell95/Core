using System;
using Microsoft.AspNetCore.Mvc;
using Core.Models;

namespace Core.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Pokemon Api";
            return View();
        }
    }
}