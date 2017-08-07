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
            List<AccountItemClass> AccountItemModel = new List<AccountItemClass>
            {
                new AccountItemClass() {Type="支出",AccountDate=new DateTime(2016,1,1),Payment=100 },
                new AccountItemClass() {Type="支出",AccountDate=new DateTime(2017,1,1),Payment=200 },
                new AccountItemClass() {Type="支出",AccountDate=new DateTime(2018,1,1),Payment=300 },
            };
            return View(AccountItemModel);
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