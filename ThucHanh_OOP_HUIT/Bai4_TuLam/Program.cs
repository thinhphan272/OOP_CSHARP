using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_TuLam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            DSThiSinh lst = new DSThiSinh();
            lst.NhapDS();

            lst.XuatDS();

            lst.ThiSinh_Dau();

            Console.WriteLine("\nTổng số thi sinh đậu: {0}", lst.tongThiSinh_Dau());
            Console.WriteLine("\nTổng số thí sinh rớt: {0}", lst.tongThiSinh_Rot());

            Console.WriteLine("Nhập mã thí sinh: ");
            string maTS = Console.ReadLine();
            lst.SeachTS(maTS);


            Console.WriteLine("Danh sách thí sinh giảm dần theo điểm tổng kết: ");
            DSThiSinh lst1 = lst.SortDecreasing();
            lst1.XuatDS();



            Console.ReadLine();
        }
    }
}
