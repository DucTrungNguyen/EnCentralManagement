using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnCentralManagement.Areas.Admin.Controllers
{
    public class QuanLyPhuHuynhController : Controller
    {
        // GET: Admin/QuanLyPhuHuynh
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ThemPhuHuynh()
        {
            return View();
        }
        public ActionResult XemThongTinPhuHuynh()
        {
            return View();
        }
    }
}