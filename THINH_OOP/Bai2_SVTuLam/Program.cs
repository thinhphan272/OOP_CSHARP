using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_SVTuLam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            CongTy dshd = new CongTy();
            dshd.Nhap_XML(@"..\..\QL_HoaDon.xml");

            dshd.XuatDS();

            Console.WriteLine("\nTổng thành tiền các hóa đơn: {0:N0} VNĐ", dshd.tongThanhTien());

            Console.WriteLine("\nThông tin khách hàng có số lượng mua nhiều nhất:\n");
            List<HoaDon> ds1 = dshd.soLuongMuaNhieuNhat();
            foreach(HoaDon x in ds1 )
            {
                x.Xuat();
            }
            
                
           



            Console.WriteLine("\nTổng tiền chiết khấu với khách hàng công ty: {0:N0}VNĐ", dshd.tongChietKhau_KHCongTy());
            
           


            Console.WriteLine("\nDanh sách Đại Lý Cấp 1:\n");
            dshd.XuatDaiLyCap1();

            Console.WriteLine("\nSắp xếp danh sách tăng dần theo số lượng, số lượng bằng thì giảm dần theo thành tiền\n");
            List<HoaDon> ds2 = dshd.SapXepDSTangDan();
            
            foreach(HoaDon y in ds2 )
            {
                y.Xuat();
            }

            Console.Write("\nNhập mã khách hàng:");

            
            string maKH = Console.ReadLine();

            
            Console.WriteLine();
            List<HoaDon> dsTimKiem = dshd.timHoaDonTheoMaKH(maKH);

            if(dsTimKiem.Count > 0 )
            {
                foreach (HoaDon z in dsTimKiem)
                {
                    z.Xuat();
                }
            }
            else
                Console.WriteLine("Khách hàng lạ!");

            
            Console.ReadLine();
        }
    }
}
