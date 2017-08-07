using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAccountBook_MVC.Models
{
    public class AccountItemClass
    {
        public String Type { get; set; }
        public DateTime AccountDate { get; set; }
        public int Payment { get; set; }
    }
}