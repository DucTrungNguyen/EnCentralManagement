using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnCentralManagement.Areas.Admin.Controllers
{
    public class QuanLyHocSinhController : Controller
    {
        // GET: Admin/QuanLyHocSinh
        public ActionResult Index()
        {
            //TempData["tb"] = ;
            return View();
        }

        public ActionResult ThemHocSinh()
        {
            return View();
        }

        public ActionResult XemThongTinHocSinh()
        {
            return View();
        }
    }
}