using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_HuongDan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //NhanVien nv = new NhanVien();
            //nv.NhapNV();
            //nv.XuatNV();

            //NhanVien nv2 = new NhanVien("NV002", "Nguyễn Thế Quang", 3.4, 2029);

            //nv2.XuatNV();
            //NhanVien nv3 = new NhanVien("NV003", "Nguyễn Trường Nhu", -1, 2025);
            //nv3.XuatNV();

            Console.WriteLine("Danh sách nhân viên");
            Lst_NhanVien lst = new Lst_NhanVien();
            lst.NhapDS();
            lst.XuatDS();

            Console.WriteLine("\nNhân viên có lương cao nhất");
            NhanVien a = lst.Max_Luong_NV();
            a.XuatNV();

            Console.WriteLine("\nDanh sách nhân viên sắp xếp giảm dần theo năm vào làm:");
            Lst_NhanVien lst2 = lst.sortIncreasing();
            lst2.XuatDS();

            Console.ReadLine();
        }
    }
}
