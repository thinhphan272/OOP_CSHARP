using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3_VeNha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DanhSachMonHoc lst = new DanhSachMonHoc();
            lst.Nhap_XML(@"..\..\DSMonHoc.xml");
            lst.XuatDS();

            Console.WriteLine("\nTrung bình tích lũy: {0:N2}", lst.TbTichLuy());

            Console.WriteLine("\nTổng học phí: {0:N0}", lst.tongTienHoc());

            Console.ReadLine();

        }
    }
}
