using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_BTVN_P45
{
    internal class ChiTietBH
    {
        string maSP;

        public string MaSP
        {
            get
            {
                return maSP;
            }
            set
            {
                if(!value.StartsWith("SP") || value.Length != 6)
                {
                    Console.WriteLine("Sai cú pháp mã sản phẩm!");
                    maSP = "SP0000";
                }
                else
                {
                    maSP = value;
                }
            }
        }
        string tenSP;

        public string TenSP
        {
            get
            {
                return tenSP;
            }
            set
            {
                tenSP = value;
            }
        }
        float giaBan;

        public float GiaBan
        {
            get
            {
                return giaBan;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Giá bán không được nhỏ hơn 0!");
                    giaBan = 0f;
                } 
                else
                {
                    giaBan = value;
                }    
                
            }
        }
        int soLuongBan;

        public int SoLuongBan
        {
            get
            {
                return soLuongBan;
            }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Số lượng không được nhỏ hơn 0!");
                    soLuongBan = 0;
                }    
                else
                    soLuongBan = value;
            }
        }

        public ChiTietBH()
        {
            MaSP = "SP0010";
            TenSP = "May tinh Dell";
            SoLuongBan = 2;
            GiaBan = 15000f;
        }

        public ChiTietBH(string maSP, string tenSP, float giaBan, int soLuongBan)
        {
            MaSP = maSP;
            TenSP = tenSP;
            GiaBan = giaBan;
            SoLuongBan = soLuongBan;
        }

        public ChiTietBH(ChiTietBH ct)
        {
            MaSP = ct.MaSP;
            TenSP = ct.TenSP;
            GiaBan = ct.GiaBan;
            SoLuongBan = ct.SoLuongBan;
        }

        public static float thueVAT = 0.1f;
        public double tinhThanhTien()
        {
            return (double) SoLuongBan * GiaBan * (1 + thueVAT);
        }

        public void NhapCT()
        {
            Console.WriteLine("Nhập mã sản phẩm: ");
            MaSP = Console.ReadLine();
            Console.WriteLine("Nhập tên sản phẩm: ");
            TenSP = Console.ReadLine();
            Console.WriteLine("Giá bán: ");
            GiaBan = float.Parse(Console.ReadLine());
            Console.WriteLine("Số lượng bán: ");
            SoLuongBan = int.Parse(Console.ReadLine());
        }

        public void XuatCT()
        {
            Console.WriteLine("| {0} | {1} | {2} | {3} | {4} |",
                MaSP.PadRight(6),
                TenSP.PadRight(20),
                GiaBan.ToString("0.0").PadRight(6),
                SoLuongBan.ToString().PadRight(5),
                tinhThanhTien().ToString("0.0").PadRight(6)
                );
        }

    }
}
