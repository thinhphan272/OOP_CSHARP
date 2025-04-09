using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_TuLam
{
    internal class MonHoc
    {
        string maMH;

        public string MaMH
        {
            get
            {
                return maMH;
            }
            set
            {
                maMH = value;
            }
        }


        string tenMH;

        public string TenMH
        {
            get
            {
                return tenMH;
            }
            set
            {
                tenMH = value;
            }
        }
        float diemThgX;

        public float DiemThgX
        {
            get
            {
                return diemThgX;
            }
            set
            {
                diemThgX = value;
            }
        }
        float diemGiuaKi;

        public float DiemGiuaKi
        {
            get
            {
                return diemGiuaKi;
            }
            set
            {
                diemGiuaKi = value;
            }
        }


        float diemCuoiKi;

        public float DiemCuoiKi
        {
            get
            {
                return diemCuoiKi;
            }
            set
            {
                diemCuoiKi = value;
            }
        }

        public MonHoc()
        {
            MaMH = null;
            TenMH = null;
            DiemThgX = 0;
            DiemGiuaKi = 0;
            DiemCuoiKi = 0;

        }

        public MonHoc(string maMH, string tenMH, float diemThgX, float diemGiuaKi, float diemCuoiKi)
        {
            this.MaMH = maMH;
            this.TenMH = tenMH;
            DiemThgX = diemThgX;
            DiemGiuaKi = diemGiuaKi;
            DiemCuoiKi = diemCuoiKi;
        }

        public MonHoc(MonHoc mh)
        {
            this.MaMH = mh.MaMH;
            this.TenMH = mh.TenMH;
            this.DiemThgX = mh.DiemThgX;
            this.DiemGiuaKi = mh.DiemGiuaKi;
            this.DiemCuoiKi = mh.DiemCuoiKi;
        }


        public double diemTongKet()
        {
            return ((DiemThgX) + (DiemGiuaKi * 2) + (DiemCuoiKi * 3)) / 6;
        }

        public string tinhKetQua()
        {
            if (diemTongKet() >= 5)
                return "Đạt";
            else
                return "Không đạt";
        }

        public void NhapMH()
        {
            Console.WriteLine("Nhập mã môn học: ");
            MaMH = Console.ReadLine();
            Console.WriteLine("Nhập tên môn học: ");
            TenMH = Console.ReadLine();
            Console.WriteLine("Nhập điểm kiểm tra thường xuyên: ");
            DiemThgX = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm kiểm tra giữa kì: ");
            DiemGiuaKi = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm kiểm tra cuối kì: ");
            DiemCuoiKi = float.Parse(Console.ReadLine());

        }

        public void XuatMH()
        {
            Console.WriteLine("{0} \t {1} \t\t {2} \t\t {3} \t\t {4} \t\t {5} \t\t {6}", MaMH, TenMH, DiemThgX, DiemGiuaKi, DiemCuoiKi, Math.Round(diemTongKet(), 2),tinhKetQua());

        }
    }
}
