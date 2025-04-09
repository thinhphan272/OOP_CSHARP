using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi07_OOP
{
    public class CChPhat24h : CVanChuyen
    {
        private double kichThuoc;

        public CChPhat24h(double kichThuoc, string maVanDon, string tenNguoiGui, string diaChiNguoiGui, string tenNguoiNhan, string diaChiNguoiNhan, DateTime ngayGui, string tuyenVC, double soKG)
        {
            this.kichThuoc = kichThuoc;
        }


        public double phiVuotKho()
        {
            if (kichThuoc)
        }

        public void tinhPhiDamBao()
        {
            throw new System.NotImplementedException();
        }

        public override double tinhCuoc()
        {
            throw new NotImplementedException();
        }
    }
}