using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_4_ActionResult_Type.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Okurmusun(string isim, int yas)
        {
            if (isim == "Negan" && yas == 52)
            {
                return View();
            }
            return RedirectToAction("Index", "Default"); // Default controllerinin Index Sayfası.
        }
    }
}