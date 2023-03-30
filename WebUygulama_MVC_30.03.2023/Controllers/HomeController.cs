using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUygulama_MVC_30._03._2023.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()//Bu bir get isteği gerçekleştiren metotdur.[HTTP get]
        {
            return View();
        }

        public ActionResult Index2()
        {

            return View();

        }

        public ActionResult Index3()
        {
            return View();
        }
    }
}