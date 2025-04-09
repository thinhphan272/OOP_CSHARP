using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_PhanSiThinh_2001230933
{
    class Program
    {
        static void Main(string[] args)
        {
            //ChiTietSanPham x = new ChiTietSanPham();
            //x.XuatSP();

            HoaDon hd = new HoaDon();
            hd.DocDSHoaDon(@"..\..\HoaDon.xml");
            hd.XuatDSHoaDon();

            Console.WriteLine("\nTong tien hoa don {0}", hd.TongHoaDon().ToString("0.0"));

            Console.WriteLine("San pham co thanh tien chi tiet cao nhat:");

            ChiTietSanPham x = hd.sp_tienCT_Max();
            x.XuatSP();

            Console.WriteLine("San pham theo ma");
            hd.xuatSP_theoMa("SP010");

            Console.WriteLine("Danh sach san pham tra");
            HoaDon hd1 = hd.Loc_Sp_Tra();
            hd1.XuatDSHoaDon();

            Console.WriteLine("Sap xep danh sach tang dan theo so luong");
            HoaDon hd2 = hd.sort_Tang_Dan();
            hd2.XuatDSHoaDon();

            Console.ReadLine();

        }
    }
}
