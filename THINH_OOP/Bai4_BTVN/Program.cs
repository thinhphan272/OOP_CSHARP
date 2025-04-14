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

            HoaDon hd = new HD_ThanThiet();
            hd.Xuat();


            Console.ReadLine();
            
        }                     
    }
}
