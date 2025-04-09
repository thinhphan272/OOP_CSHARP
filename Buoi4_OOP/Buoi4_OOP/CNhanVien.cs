using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi4_OOP
{
    public class CNhanVien
    {
        private string maNV;
        private string hoTen;
        private double heSoLuong;
        private int NVL;

        public static long MLTT;

        static CNhanVien()
        {
            MLTT = 1800;
        }

        public static void capNhatMLTT(long mltt)
        {
            MLTT = mltt;
        }

        public CNhanVien() { }
        public CNhanVien(string maNV, string hoTen, double heSoLuong, int nVL)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.heSoLuong = heSoLuong;
            NVL = nVL;
        }
        public CNhanVien(CNhanVien obj)
        {
            this.maNV = obj.maNV;
            this.hoTen = obj.hoTen;
            this.heSoLuong=obj.heSoLuong;
            this.NVL = obj.NVL;
        }

        public double tinhLuong()
        {
            double lcb = heSoLuong * MLTT;
            double hspctn = (double)(DateTime.Now.Year - NVL) / 100;
            return lcb * (1 + hspctn);
        }
        public void showTT()
        {
            Console.WriteLine($"{maNV}  {hoTen}  {heSoLuong} {NVL}  {tinhLuong()}");
        }
    }


}