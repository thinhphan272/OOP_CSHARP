using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_BTVN_P45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            HoaDon hd = new HoaDon();
            hd.NhapHD();
            hd.XuatHD();

            Console.WriteLine("\nTrị giá hóa đơn: {0}", hd.tinhTriGia().ToString("0.0"));

            Console.WriteLine("\nDanh sách hóa đơn giảm dần theo thành tiền: ");
            HoaDon hd1 = hd.SortDeacreasing();
            hd1.XuatHD();

            Console.WriteLine("\nThông tin sản phẩm được mua có thành tiền lớn nhất: ");
            ChiTietBH x = hd.Sp_ThanhTien_Max();
            x.XuatCT();


            Console.ReadLine();
        }
    }
}
