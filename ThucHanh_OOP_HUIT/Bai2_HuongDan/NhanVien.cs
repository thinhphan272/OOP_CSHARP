using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_HuongDan
{
    internal class NhanVien
    {
        string maNV;

        public string MaNV
        {
            get
            { 
                return maNV;
            }
            set
            {
                maNV = value;
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
        double heSoLg;

        public double HeSoLg
        {
            get
            {
                return heSoLg;
            }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Hệ số lương phải lớn hơn 0!!");
                    heSoLg = 0;
                }
                heSoLg = value;
            }
        }
        int namVaoLam;
        
        public int NamVaoLam
        {
            get 
            {
                return namVaoLam;
            }
            set
            {
                if(value < 0 || value > DateTime.Today.Year)
                {
                    Console.WriteLine("Năm vào làm không được lớn hơn năm hiện tại!!");
                    namVaoLam = DateTime.Today.Year;

                }
                else
                {
                    namVaoLam = value;
                }    
                    
            }
        }
        

        public NhanVien()
        {
            MaNV = null;
            HoTen = null;
            HeSoLg = 0;
            NamVaoLam = DateTime.Today.Year;

        }    
        public NhanVien(string maNV, string hoTen, double heSoLg, int  namVaoLam)
        {
            MaNV = maNV;
            HoTen = hoTen;
            HeSoLg = heSoLg;
            NamVaoLam = namVaoLam;
        }    

        public NhanVien(NhanVien nv)
        {
            MaNV = nv.MaNV;
            HoTen = nv.HoTen;
            HeSoLg = nv.HeSoLg;
            NamVaoLam = nv.NamVaoLam;
        }

        public static int mucLuongToiThieu = 2340000;

        public double heSoPhuCapThamNien()
        {
            return (double)(DateTime.Today.Year - NamVaoLam) / 100;
        }    

        public double LuongCoBan()
        {
            return (double) HeSoLg * mucLuongToiThieu;
        }    
        public double TinhLuong_Moi_NV()
        {
            return (double) LuongCoBan() * (1 + heSoPhuCapThamNien());
        }  
        
        public void NhapNV()
        {
            Console.WriteLine("Nhập mã nhân viên: ");
            MaNV = Console.ReadLine();
            Console.WriteLine("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhập hệ số lương: ");
            HeSoLg = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập năm vào làm: ");
            NamVaoLam = int.Parse(Console.ReadLine());
        }    

        public void XuatNV()
        {
            Console.WriteLine("\nMã NV: {0} \t Họ tên NV: {1} \t Hệ số lương: {2} \t Năm vào làm: {3} \t Lương: {4}", MaNV, HoTen, HeSoLg, NamVaoLam, TinhLuong_Moi_NV());
            
        }    
        

    }
}
