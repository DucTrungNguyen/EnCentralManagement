using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnCentralManagement.Areas.Admin.Controllers
{
    public class QuanLyGiaoVienController : Controller
    {
        // GET: Admin/QuanLyGiaoVien
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ThemGiaoVien()
        {
            return View();
        }

        public ActionResult XemThongTinGiaoVien()
        {
            return View();
        }
    }
}