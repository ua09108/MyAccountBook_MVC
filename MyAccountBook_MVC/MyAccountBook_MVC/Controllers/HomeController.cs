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
        private readonly AccountService _accService;

        public HomeController()
        {
            _accService = new AccountService();
        }

        public ActionResult Index()
        {
            return View(_accService.GetData());
        }

        public ActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,Categoryyy,Amounttt,Dateee,Remarkkk")] AccountBook accountbook)
        {
            if (ModelState.IsValid)
            {
                _accService.Add(accountbook);
                _accService.Save();
                //return RedirectToAction("Index");

                return View();

            }

            return View(accountbook);

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