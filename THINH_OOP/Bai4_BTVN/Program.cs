using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_BTVN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            CuaHangXangDau ch1 = new CuaHangXangDau();
            ch1.Nhap_Xml(@"..\..\XMLFile1.xml");

            ch1.XuatDS();

            Console.WriteLine("\nTổng trị giá: {0:N0}", ch1.tinhTongHD());

            Console.WriteLine("\nHóa đơn có trị giá cao nhất:");
            List<HoaDon> ch2 = ch1.xuatHoaDon_Max();
            foreach(HoaDon x in ch2 )
            {
                x.Xuat();
            }

            Console.WriteLine("\nSố hóa đơn của khách vip và khách thân thiết {0}", ch1.demHoaDon_KhachThanThiet() + ch1.demHoaDon_KhachVIP());

            Console.WriteLine("\nSắp xếp danh sách: ");

            List<HoaDon> dsSapXep = ch1.sapXep();
            foreach(HoaDon y in dsSapXep )
            {
                y.Xuat();
            }    
            

            Console.ReadLine();
            
        }                     
    }
}
