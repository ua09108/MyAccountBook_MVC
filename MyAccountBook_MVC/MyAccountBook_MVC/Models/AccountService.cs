using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAccountBook_MVC.Models
{
    public class AccountService
    {
        private readonly SkillTreeHomeworkEntities _db;
        
        public AccountService()
        {
            _db = new SkillTreeHomeworkEntities();
        }

        public IEnumerable<AccountBook> GetData()
        {
            return _db.AccountBook.ToList();
        }
    }
}