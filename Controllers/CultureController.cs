using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataTableWebAPI.Controllers
{
    public class CultureController : Controller
    {
        // GET: Culture
        public ActionResult ChangeCulture(string lang)
        {
            if (!string.IsNullOrEmpty(lang))
            {
                var cookie = new HttpCookie("culture", lang)
                {
                    Expires = DateTime.Now.AddYears(1)
                };
                Response.Cookies.Add(cookie);
            }
            return Redirect(Request.UrlReferrer.ToString());
        }
    }
}
