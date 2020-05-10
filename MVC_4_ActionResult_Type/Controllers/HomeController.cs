using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_4_ActionResult_Type.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public RedirectToRouteResult Index2()
        {
            return RedirectToAction("Index"); // Action'a yönlendirir.
        }

        public JsonResult Index3()
        {
            Kisi kisi = new Kisi();
            kisi.adi = "Negan";
            kisi.soyadi = "Lucille";
            return Json(kisi, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index4()
        {
            // ActionResult tipi: Bütün result tiplerinin atasıdır.
            return View();
        }
    }

    public class Kisi
    {
        public string adi { get; set; }
        public string soyadi { get; set; }
    }
}