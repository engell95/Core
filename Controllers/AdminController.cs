using System;
using Microsoft.AspNetCore.Mvc;
using Core.Models;

namespace Core.Controllers
{
    public class AdminController :Controller
    {
        public IActionResult Index(){
            var Users = new Users();
            Users.number = 9999;
            Users.number_intern = 10190;
            Users.email = "example@lol.com";
            Users.nickname = "example";

            ViewBag.Login = "CURRENTUSER";
            ViewBag.Server = "LOCALHOST";

            return View(Users);
        }
    }
}
