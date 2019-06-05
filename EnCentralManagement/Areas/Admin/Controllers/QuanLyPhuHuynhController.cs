using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EnCentralManagement.Areas.Admin.Models;
using System.Web.Mvc;

namespace EnCentralManagement.Areas.Admin.Controllers
{

    public class QuanLyPhuHuynhController : Controller
    {
        AppDataQLCTEntities db = new AppDataQLCTEntities();
        // GET: Admin/QuanLyPhuHuynh
        public ActionResult Index()
        {
            return View(db.PHU_HUYNH);
        }
        public ActionResult ThemPhuHuynh()
        {
            ViewBag.isThemPhuHuynh = true;
            ViewBag.action = Url.Action("ThemPhuHuynhDB", "QuanLyPhuHuynh");
            return View("ThemPhuHuynh");
        }
        public ActionResult ThemPhuHuynhDB(FormCollection form)
        {

            if (db.PHU_HUYNH.Find(form["nf-email"]) == null && !String.IsNullOrEmpty(form["nf-password"].ToString()))
            {
                PHU_HUYNH ph = new PHU_HUYNH()
                {
                    HO_TEN = form["cc-payment"],
                    DIA_CHI = form["cc-name"],
                    SO_DIENTHOAI = form["cc-number"],
                    NGAY_SINH = DateTime.Now,
                    ID = form["nf-email"],
                    PASS_WORD = form["nf-password"]
                };

                db.PHU_HUYNH.Add(ph);
                db.SaveChanges();
                ViewBag.idTonTai = true;

            }
            else
            {
                ViewBag.idTonTai = true;
            }


            return View("ThemPhuHuynh");
        }
        public ActionResult SuaPhuHuynh(string id)
        {
            return View("ThemPhuHuynh", db.PHU_HUYNH.Find(id));
        }
        public ActionResult XemThongTinPhuHuynh(string id)
        {
            return View("XemThongTinPhuHuynh", db.PHU_HUYNH.Find(id));
        }
    }
}