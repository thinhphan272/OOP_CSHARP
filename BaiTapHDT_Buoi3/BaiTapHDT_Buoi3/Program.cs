using BaiTapOOP_TrenLop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapHDT_Buoi3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine("Nhập số sản phẩm muốn thêm: ");
            n = int.Parse(Console.ReadLine());
            CSanPham[] danhSachSP = new CSanPham[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin sản phẩm thứ {i + 1}");
                Console.Write("Tên sản phẩm ");
                string tenSp = Console.ReadLine();

                Console.Write("\nĐơn giá: ");
                double donGia = double.Parse(Console.ReadLine());

                Console.Write("\nGiảm giá: ");
                double giamGia = double.Parse(Console.ReadLine());

                danhSachSP[i] = new CSanPham(tenSp, donGia, giamGia);
            }

            Console.WriteLine("\nThông tin các sản phẩm đã nhập");
            foreach (var ds in danhSachSP)
            {
                ds.xuat();
            }

            Console.ReadKey();

        }
    }
}
