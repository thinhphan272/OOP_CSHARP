using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_TuLam
{
    internal class ThiSinh
    {
        string maTS;

        public string MaTS
        {
            get
            {
                return maTS;

            }
            set
            {
                maTS = value;
            }

        }
        string hoTen;

        public string HoTen
        {
            get
            {
                return hoTen;

            }
            set
            {
                hoTen = value;
            }

        }

        string gioiTinh;

        public string GioiTinh
        {
            get
            {
                return gioiTinh;

            }
            set
            {
                gioiTinh = value;
            }

        }
        float diemLT;

        public float DiemLT
        {
            get
            {
                return diemLT;

            }
            set
            {
                diemLT = value;
            }

        }
        float diemTH;
        public float DiemTH
        {
            get
            {
                return diemTH;

            }
            set
            {
                diemTH = value;
            }

        }

        public ThiSinh()
        {
            MaTS = null;
            HoTen = null;
            GioiTinh = null;
            DiemLT = 0.0f;
            DiemTH = 0.0f;
        }

        public ThiSinh(string maTS, string hoTen, string gioiTinh, float diemLT, float diemTH)
        {
            MaTS = maTS;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            DiemLT = diemLT;
            DiemTH = diemTH;
        }
        public ThiSinh(ThiSinh ts)
        {
            this.MaTS = ts.MaTS;
            this.HoTen = ts.HoTen;
            this.GioiTinh = ts.GioiTinh;
            this.DiemLT = ts.DiemLT;
            this.DiemTH = ts.DiemTH;
        }

        public double tinhDiemTongKet()
        {
            return (double)(DiemLT + DiemTH) / 2;
        }

        public string xetTuyen()
        {
            if (tinhDiemTongKet() >= 5 && DiemTH >= 5.0 && DiemTH >= 5.0)
                return "Đậu";
            else
                return "Rớt";
        }

        public void NhapTS()
        {
            Console.WriteLine("Nhập mã thí sinh: ");
            MaTS = Console.ReadLine();
            Console.WriteLine("Nhập họ tên thí sinh: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhập giới tính: ");
            GioiTinh = Console.ReadLine();
            Console.WriteLine("Nhập điểm lý thuyết: ");
            DiemLT = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm thực hành: ");
            DiemTH = float.Parse(Console.ReadLine());
        }

        public void XuatTS()
        {
            Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5} | {6} |",
            MaTS.PadRight(6),
            HoTen.PadRight(20),
            GioiTinh.PadRight(9),
            DiemLT.ToString("0.0").PadRight(7),
            DiemTH.ToString("0.0").PadRight(7),
            tinhDiemTongKet().ToString("0.0").PadRight(7),
            xetTuyen().PadRight(12));
        }

    }
}
