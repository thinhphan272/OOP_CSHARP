using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi07_OOP
{
    public abstract class CVanChuyen
    {
        private string maVanDon;
        private string tenNguoiGui;
        private string diaChiNguoiGui;
        private string tenNguoiNhan;
        private string diaChiNguoiNhan;
        private System.DateTime ngayGui;
        private string tuyenVC;
        private double soKG;


        public
        public CVanChuyen()
        {
            throw new System.NotImplementedException();
        }

        public CVanChuyen(string maVanDon, string tenNguoiGui, string diaChiNguoiGui, string tenNguoiNhan, string diaChiNguoiNhan, DateTime ngayGui, string tuyenVC, double soKG)
        {
            this.maVanDon = maVanDon;
            this.tenNguoiGui = tenNguoiGui;
            this.diaChiNguoiGui = diaChiNguoiGui;
            this.tenNguoiNhan = tenNguoiNhan;
            this.diaChiNguoiNhan = diaChiNguoiNhan;
            this.ngayGui = ngayGui;
            this.tuyenVC = tuyenVC;
            this.soKG = soKG;
        }

        


        public abstract double tinhCuoc();
        
    }
}