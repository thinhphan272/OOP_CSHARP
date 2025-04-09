using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_QLMyPham
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            Console.OutputEncoding = Encoding.UTF8;

            DSKhachHang dskh = new DSKhachHang();
            dskh.NhapDSKH_Xml(@"..\..\CuaHang.xml");

            DanhSachSanPham dssp = new DanhSachSanPham();
            dssp.NhapDSSP_Xml(@"..\..\CuaHang.xml");

            int luaChon;

            do
            {
                Console.Clear(); // Xóa màn hình sau mỗi vòng lặp
                Console.WriteLine("========= QUẢN LÝ MỸ PHẨM =========");
                Console.WriteLine("1. Xem danh sách khách hàng");
                Console.WriteLine("2. Xem danh sách sản phẩm");
                Console.WriteLine("3. Thêm sản phẩm vào danh sách");
                Console.WriteLine("4. Lọc sản phẩm theo xuất xứ");
                Console.WriteLine("5. Lọc khách hàng theo tên");
                Console.WriteLine("6. Cập nhật giá bán của sản phẩm TRANG ĐIỂM (tăng 3%)");
                Console.WriteLine("7. Xem danh sách sản phẩm có giá bán trên 300000");
                Console.WriteLine("8. Xem danh sách sản phẩm TRANG ĐIỂM");
                Console.WriteLine("9. Xem danh sách khách hàng mua nhiều hơn 3 sản phẩm");
                Console.WriteLine("10. Xem danh sách sản phẩm có ngày sản xuất trên 3 tháng");
                Console.WriteLine("0. Thoát chương trình");
                Console.Write("\nNhập lựa chọn của bạn: ");

                luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 1:
                        Console.WriteLine("\n===== DANH SÁCH KHÁCH HÀNG =====");
                        dskh.XuatDSKH();
                        break;

                    case 2:
                        Console.WriteLine("\n===== DANH SÁCH SẢN PHẨM =====");
                        dssp.XuatDSSP_Abstract();
                        break;

                    case 3:
                        Console.WriteLine("\n===== THÊM SẢN PHẨM MỚI =====");
                        dssp.NhapDSSP();
                        Console.WriteLine("\nDanh sách sau khi thêm:");
                        dssp.XuatDSSP();
                        break;

                    case 4:
                        Console.Write("\nNhập nơi xuất xứ: ");
                        string xuatXu = Console.ReadLine();
                        DanhSachSanPham ds1 = dssp.Loc_Theo_XuatXu(xuatXu);
                        ds1.XuatDSSP();
                        break;

                    case 5:
                        Console.Write("\nNhập tên khách hàng: ");
                        string tenKH = Console.ReadLine();
                        DSKhachHang dskh1 = dskh.XuatDS_Theo_TenKH(tenKH);
                        dskh1.XuatDSKH();
                        break;

                    case 6:
                        Console.WriteLine("\n===== CẬP NHẬT GIÁ BÁN (TĂNG 3%) =====");
                        DSTrangDiem ds = new DSTrangDiem();
                        ds.NhapDSTrangDiem_Xml("CuaHang.xml");

                        Console.WriteLine("\n--- DANH SÁCH TRƯỚC KHI CẬP NHẬT GIÁ ---");
                        ds.XuatDSSP_Abstract();

                        ds.CapNhatGiaBan_Tang3_PhanTram();

                        Console.WriteLine("\n--- DANH SÁCH SAU KHI CẬP NHẬT GIÁ (TĂNG 3%) ---");
                        ds.XuatDSSP_Abstract();
                        break;

                    case 7:
                        Console.WriteLine("\n===== DANH SÁCH SẢN PHẨM CÓ GIÁ BÁN HƠN 300000 =====");
                        DanhSachSanPham spHon300 = dssp.Loc_DSSP_GiaBan_Hon300000();
                        spHon300.XuatDSSP_Abstract();
                        break;
                    case 8:
                        Console.WriteLine("\n===== DANH SÁCH SẢN PHẨM TRANG ĐIỂM =====");
                        dssp.Xuat_SP_TrangDiem();
                        break;

                    case 9:
                        Console.WriteLine("\n===== DANH SÁCH KHÁCH HÀNG MUA HƠN 3 SẢN PHẨM =====");
                        dskh.XuatDSKH_MuaNhieuHon3SP();
                        break;

                    case 10:
                        Console.WriteLine("\n===== DANH SÁCH SẢN PHẨM CÓ NGÀY SẢN XUẤT TRÊN 3 THÁNG =====");
                        DanhSachSanPham dssp3 = dssp.Loc_DSSP_NgaySXHon3Thang();
                        dssp3.XuatDSSP_Abstract();
                        break;

                    case 0:
                        Console.WriteLine("\nKết thúc chương trình!");
                        break;

                    default:
                        Console.WriteLine("\nLựa chọn không hợp lệ! Vui lòng nhập lại.");
                        break;
                }

                Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();

            } while (luaChon != 0);


            Console.ReadLine();

            
        }
    }
}
