using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TranVanBang_De2.Models
{
    public class SanPham
    {
        public SanPham()
        {
        }

        public SanPham(string maSanPham, string tenSanPham, string loaiSanPham, int soLuong, int donGia, decimal thanhTien)
        {
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            LoaiSanPham = loaiSanPham;
            SoLuong = soLuong;
            DonGia = donGia;
            ThanhTien = thanhTien;
        }

        public string MaSanPham {  get; set; }
        public string TenSanPham { get; set; }
        public string LoaiSanPham { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public decimal ThanhTien { get; set; }

    }
}