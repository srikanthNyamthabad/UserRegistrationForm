using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserRegistrationForm.Models;
using UserRegistrationForm.Services;

namespace UserRegistrationForm.Controllers
{
    public class HomeController : Controller
    {
      

        public UserContext _db;
        public HomeController(UserContext db)
        {
            _db = db;
        }


        public ActionResult AddUser()
        {

            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddUser(User obj)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    if (obj.userId==0)
                    {
                        _db.Users.Add(obj);
                        _db.SaveChanges();
                       
                    }
                    
                }
                else
                {
                    return View(obj);
                }
       
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");

        }

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}


    }
}
