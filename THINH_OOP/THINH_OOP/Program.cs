using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THINH_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            CongTyABC dsnv = new CongTyABC();
            dsnv.Nhap_XML(@"..\..\XMLFile1.xml");

            dsnv.XuatDS();

            Console.WriteLine("Tổng thu nhập của công ty: {0}",dsnv.TongThuNhap());

            Console.ReadLine();
        }
    }
}
