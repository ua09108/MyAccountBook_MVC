using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyAccountBook_MVC.Models;

namespace MyAccountBook_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AccountService _accService = new AccountService();
            return View(_accService.GetData());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}