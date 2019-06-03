using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EnCentralManagement.Areas.Admin.Models;
using Newtonsoft.Json;

namespace EnCentralManagement.Areas.Admin.Controllers
{
    public class QuanLyHocSinhController : Controller
    {
        AppDataQLCTEntities db = new AppDataQLCTEntities();
        // GET: Admin/QuanLyHocSinh
        public ActionResult Index()
        {
            //TempData["tb"] = ;
           
            return View(db.HOC_SINH);
        }

        public ActionResult ThemHocSinh(FormCollection form)
        {
            HOC_SINH hs = new HOC_SINH()
            {

            };
            ViewBag.isThemHocSinh = true;
            ViewBag.action = Url.Action("ThemHocSinhDB", "QuanLyHocSinh");
            return View("ThemHocSinh");
        }
        public ActionResult ThemHocSinhDB(FormCollection form)
        {
           
            if ( db.HOC_SINH.Find(form["nf-email"]) == null && !String.IsNullOrEmpty(form["nf-password"].ToString()))
            {
                HOC_SINH hs = new HOC_SINH()
                {
                    HO_TEN = form["cc-payment"],
                    DIA_CHI = form["cc-name"],
                    SO_DIENTHOAI = form["cc-number"],
                    NGAY_SINH = DateTime.Now,
                    ID = form["nf-email"],
                    PASS_WORD = form["nf-password"]
                };

                db.HOC_SINH.Add(hs);
                db.SaveChanges();
                ViewBag.idTonTai = true;

            }
            else
            {
                ViewBag.idTonTai = true;
            }

           
            return View("ThemHocSinh");
        }

        public ActionResult SuaHocSinh(string id)
        {
            ViewBag.action = Url.Action("SuaHocSinh", "QuanLyHocSinh",new { id= id });
            ViewBag.isThemHocSinh = false;
           
            // hi hi :) nho nham param
            return View("ThemHocSinh", db.HOC_SINH.Find(id));
        }
        public ActionResult XemThongTinHocSinh(string id)
        {
            return View("XemThongTinHocSinh", db.HOC_SINH.Find(id));
        }
    }
}