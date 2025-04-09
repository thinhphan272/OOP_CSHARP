using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_BTVN_P45
{
    internal class HoaDon
    {
        string maHD;

        public string MaHD
        {
            get
            {
                return maHD;
            }
            set 
            {
                maHD = value;
            }
        }
        string tenKhach;

        public string TenKhach
        {
            get
            {
                return tenKhach;
            }
            set
            {
                tenKhach = value;
            }
        }
        List<ChiTietBH> lstChiTietBH = new List<ChiTietBH>();

        public List<ChiTietBH> LstChiTietBH
        {
            get 
            {
                return lstChiTietBH;
            }
            set
            {
                lstChiTietBH = value;
            }
        }

        public HoaDon()
        {
            LstChiTietBH = new List<ChiTietBH>();
        }

        public HoaDon(string maHD, string tenKhach, List<ChiTietBH> lstChiTietBH)
        {
            MaHD = maHD;
            TenKhach = tenKhach;
            LstChiTietBH = lstChiTietBH;
        }

        public HoaDon(HoaDon hd)
        {
            MaHD = hd.MaHD;
            TenKhach = hd.TenKhach;
            LstChiTietBH = hd.LstChiTietBH;
        }

        public ChiTietBH Sp_ThanhTien_Max()
        {
            double max = LstChiTietBH.Max(t => t.tinhThanhTien());

            return LstChiTietBH.FirstOrDefault(t => t.tinhThanhTien() == max);
            
        }


        public HoaDon SortDeacreasing()
        {
            HoaDon x = new HoaDon();
            x.LstChiTietBH = LstChiTietBH.OrderByDescending(t => t.tinhThanhTien()).ToList();
            return x;
        }
        public double tinhTriGia()
        {
            return LstChiTietBH.Sum(t => t.tinhThanhTien()); 
        }

        public void NhapHD()
        {
            Console.WriteLine("Nhập mã hóa đơn: ");
            MaHD = Console.ReadLine();
            Console.WriteLine("Nhập tên khách hàng: ");
            TenKhach = Console.ReadLine();
            Console.WriteLine("Nhập số lượng sản phảm: ");
            int n = int.Parse(Console.ReadLine());  

            for(int i  = 0; i < n; i++)
            {
                Console.WriteLine("Nhập sản phẩm thứ {0}", i + 1);
                ChiTietBH x = new ChiTietBH();
                x.NhapCT();
                LstChiTietBH.Add(x);
            }    
        }

        public void XuatHD()
        {
            Console.WriteLine("-----------Thông tin hóa đơn-----------");
            Console.WriteLine("Mã hóa đơn: {0}", MaHD);
            Console.WriteLine("Tên khách hàng: {0}", TenKhach);

            Console.WriteLine("-----------Danh sách sản phẩm-----------");
            foreach(ChiTietBH x in LstChiTietBH) 
            {
                x.XuatCT();
            }
        }

    }
}
