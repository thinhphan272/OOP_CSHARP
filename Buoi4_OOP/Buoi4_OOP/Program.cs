using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4_OOP
{
    internal class Program
    {
        static int x = 100;

        static void nhapSoNguyen()
        {

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CNhanVien nv1 = new CNhanVien("NV001", "Trần Lả Lướt", 2.34,2020);
            CNhanVien nv2 = new CNhanVien("NV002", "Nguyễn Băng Qua", 2.34, 2018);

            nv1.showTT();
            nv2.showTT();
            CNhanVien.capNhatMLTT(2340);

            nv1.showTT();
            nv2.showTT();

            Console.ReadKey();
        }
    }
}
