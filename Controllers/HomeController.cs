using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travelancar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult TravelancarDashboard()
        {
            ViewBag.Message = "Dashboard";

            return View();
        }

        public ActionResult DaftarPesanan()
        {
            ViewBag.Message = "Daftar Pesanan";

            return View();
        }

        public ActionResult DetailPesanan()
        {
            ViewBag.Message = "Detail Pesanan";

            return View();
        }


    }
}