using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TranVanBang_De2.Models;

namespace TranVanBang_De2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Cau1()
        {
            return View();
        }

        public ActionResult Cau2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KetQua(SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                if (sanPham.SoLuong >= 200)
                {
                    sanPham.ThanhTien = sanPham.SoLuong * sanPham.DonGia * 0.85m;
                }
                else
                {
                    sanPham.ThanhTien = sanPham.SoLuong * sanPham.DonGia;
                }

                ViewBag.MaSanPham = sanPham.MaSanPham;
                ViewBag.TenSanPham = sanPham.TenSanPham;
                ViewBag.ThanhTien = sanPham.ThanhTien;
            } 

            return View();
        }
    }
}