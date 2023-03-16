using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            VNR_InternShipEntities db = new VNR_InternShipEntities();
            List<KhoaHoc> listKhoahoc = db.KhoaHocs.ToList();
            MonHoc_KhoaHoc monHoc_KhoaHoc = new MonHoc_KhoaHoc();
            monHoc_KhoaHoc.listKhoaHoc = listKhoahoc;
            monHoc_KhoaHoc.listMonhoc = null;
            monHoc_KhoaHoc.tenKhoaHoc = null;
            return View(monHoc_KhoaHoc);
        }

        public ActionResult LoadTenMonHoc(int id)
        {
            VNR_InternShipEntities db = new VNR_InternShipEntities();
            List<KhoaHoc> listKhoahoc = db.KhoaHocs.ToList();
            List<MonHoc> listMonHoc = db.MonHocs.ToList();
            List<MonHoc> a = new List<MonHoc>();
            foreach(MonHoc monhoc in listMonHoc)
            {
                if (monhoc.KhoaHocID == id)
                {
                    a.Add(monhoc);
                }
            }
            MonHoc_KhoaHoc monHoc_KhoaHoc = new MonHoc_KhoaHoc();
            monHoc_KhoaHoc.tenKhoaHoc = db.KhoaHocs.Find(id).TenKhoaHoc;
            monHoc_KhoaHoc.listKhoaHoc = listKhoahoc;
            monHoc_KhoaHoc.listMonhoc = a;
            return View(monHoc_KhoaHoc);
        }
    }
}