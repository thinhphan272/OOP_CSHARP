using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_TuLam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            
            HocSinh hs = new HocSinh();
            hs.NhapHS();

            hs.XuatHS();

            Console.WriteLine("Điểm trung bình tất cả các môn: {0}", Math.Round(hs.tinhDiemTB_HocKi(), 2));
            Console.WriteLine("Xếp loại học sinh: {0}", hs.xepLoai_HS());
            Console.WriteLine("Kết quả học tập: {0}", hs.xetKetQua_hocTap());

            Console.WriteLine("\nNhập mã học sinh cần tìm danh sách môn học đạt:");
            string maHS = Console.ReadLine();
            hs.DanhSachMonDat(maHS);
            Console.ReadLine();
        }
    }
}
