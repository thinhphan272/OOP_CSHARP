using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BTVN_P43
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.OutputEncoding = Encoding.UTF8;
            //NhanVien nv1 = new NhanVien("NV001", "Phan Thinh", "Kinh Doanh", "Lãnh đạo", 3.5f, 20, 23);
            //nv1.XuatNV();

            DSNhanVien ds = new DSNhanVien();
            ds.NhapDS();
            ds.XuatDS();

            ds.xuatDS_TheoHSTDua();

            Console.WriteLine("\nDanh sách nhân viên trong phòng ban Tài vụ: ");
            ds.xuatNV_theoPhongBan("Tai vu");

            ds.xuatNV_LanhDao();

            Console.WriteLine("\nTổng lương phải trả cho toàn bộ nhân viên: {0}", ds.TongLuong_NV().ToString("0.0"));

            ds.XoaNV_WorkLess10D();

            Console.WriteLine("\nDanh sách sau khi xóa các nhân viên làm ít hơn 10 ngày.");
            ds.XuatDS();

            ds.xuatNV_HSLMore4_34_TaiVu();

            Console.ReadLine();
        }
    }
}
