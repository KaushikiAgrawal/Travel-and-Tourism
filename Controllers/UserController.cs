using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project1.Models;
namespace project1.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationUser _auc;
        public UserController(ApplicationUser auc)
        {
            _auc = auc;
        }
        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registration(User uc)
        {
            _auc.Add(uc);
            _auc.SaveChanges();
            ViewBag.message = "The user " + uc.UserName + " is saved successfully";
            return View();
        }

    }
}
