using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAccountBook_MVC.Helper
{
    public static class SetTypeColor
    {
        public static MvcHtmlString SetColor(this HtmlHelper helper, string type)
        {
            if (type == "收入")
            {
                return MvcHtmlString.Create($"<font color='blue'>{type}</font>");
            }
            else
                return MvcHtmlString.Create($"<font color='red'>{type}</font>");

        }
    }
}