using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register2(FormCollection data)
        {
            ViewBag.maSV = data["maSV_name"];
            ViewBag.hoten = data["hoten_name"];
            ViewBag.diem = data["diem_name"];
            return View(ViewBag);
        }
    }
}