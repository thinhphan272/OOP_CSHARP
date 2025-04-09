using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh_Buoi4_OOP_HUIT
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            NhanVien nv = new NhanVien();
            nv.XuatNV();

            Console.ReadLine();
        }
    }
}
