using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh_OOP_HUIT
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            PhanSo a = new PhanSo();
            a.TuSo = 3;
            a.MauSo = 9;
            a.Xuat();

            PhanSo b = new PhanSo(7, 2);
            PhanSo c = a.TinhTong(b);
            c.ToiGian();
            c.Xuat();

            Lst_PhanSo lst = new Lst_PhanSo();
            lst.NhapDS();
            lst.XuatDS();

            Console.WriteLine("Tối giản danh sách");
            lst.ToiGianDS();
            lst.XuatDS();

            
            Console.WriteLine("Tim kiem. \n\t Nhập phân số cần tìm");
            PhanSo p = new PhanSo();
            p.Nhap();
            if (lst.SearchPS(p) == true)
                Console.WriteLine("Tìm thấy !!");
            else
                Console.WriteLine("Không tồn tại!!");

            
            Console.WriteLine("Danh sách sau khi sắp xếp:");
            Lst_PhanSo lst1 = lst.sortGiaTri();
            lst1.XuatDS();

            
            Console.WriteLine("Danh sách phân số > 1");
            Lst_PhanSo lst2 = lst.LocDuLieu();
            lst2.XuatDS();

            
            Console.WriteLine("Phân số lớn nhất");
            PhanSo ps = lst.ps_max();
            ps.Xuat();

            
            Console.WriteLine("Danh sách 3 phân số lớn nhất: ");
            Lst_PhanSo lst3 = lst.Top3Ps();
            lst3.XuatDS();

            Console.ReadLine();
        }
    }
}
