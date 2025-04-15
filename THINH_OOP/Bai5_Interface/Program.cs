using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bai5_Interface
{
    class Program
    {
        static List<TaiKhoanKhachHang> danhSachKhachHang = new List<TaiKhoanKhachHang>();
        static List<TaiKhoanTaiXe> danhSachTaiXe = new List<TaiKhoanTaiXe>();
        static List<ChuyenXe> danhSachChuyenXe = new List<ChuyenXe>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Tạo dữ liệu XML và đọc vào chương trình
            TaoDuLieuXML();
            DocDuLieuTuXML();

            // Menu chương trình
            while (true)
            {
                Console.WriteLine("\n=== QUẢN LÝ UBER TAXI ===");
                Console.WriteLine("1. Xuất thông tin tất cả các danh sách");
                Console.WriteLine("2. Nâng cấp khách hàng thường lên VIP nếu đi từ chuyến thứ 10");
                Console.WriteLine("3. Đếm số xe mỗi loại");
                Console.WriteLine("4. Đếm số tài khoản khách");
                Console.WriteLine("5. Xuất thông tin các tài xế lái xe gắn máy");
                Console.WriteLine("6. Tính tổng doanh thu từng loại xe trong ngày");
                Console.WriteLine("7. Xuất chuyến xe có tiền cước nhiều nhất (xe máy)");
                Console.WriteLine("8. Xuất chuyến xe có tiền cước nhiều nhất (ô tô)");
                Console.WriteLine("9. Xuất chuyến xe có tiền cước nhiều nhất (ô tô tải)");
                Console.WriteLine("10. Sắp xếp chuyến xe tăng dần theo tiền cước và mã tài xế");
                Console.WriteLine("11. Xuất thông tin khách hàng VIP");
                Console.WriteLine("12. Tìm khách hàng có số chuyến đi nhiều nhất");
                Console.WriteLine("13. Tìm tài xế có doanh thu cao nhất");
                Console.WriteLine("14. Xuất thông tin tài xế ô tô được thưởng");
                Console.WriteLine("15. Xuất thông tin tài xế ô tô tải được thưởng");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");

                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        XuatTatCaDanhSach();
                        break;
                    case 2:
                        NangCapKhachVIP();
                        break;
                    case 3:
                        DemSoXeMoiLoai();
                        break;
                    case 4:
                        DemSoTaiKhoanKhach();
                        break;
                    case 5:
                        XuatTaiXeXeMay();
                        break;
                    case 6:
                        TinhTongDoanhThuTungLoai();
                        break;
                    case 7:
                        XuatChuyenXeMayNhieuTienNhat();
                        break;
                    case 8:
                        XuatChuyenOToNhieuTienNhat();
                        break;
                    case 9:
                        XuatChuyenOToTaiNhieuTienNhat();
                        break;
                    case 10:
                        SapXepChuyenXe();
                        break;
                    case 11:
                        XuatKhachHangVIP();
                        break;
                    case 12:
                        TimKhachHangNhieuChuyenNhat();
                        break;
                    case 13:
                        TimTaiXeDoanhThuCaoNhat();
                        break;
                    case 14:
                        XuatTaiXeOToDuocThuong();
                        break;
                    case 15:
                        XuatTaiXeOToTaiDuocThuong();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }

        static void TaoDuLieuXML()
        {
            // Tạo XML cho khách hàng
            XElement dsKhachHang = new XElement("DanhSachKhachHang",
                new XElement("KhachHang",
                    new XElement("Username", "khach1"),
                    new XElement("Password", "123"),
                    new XElement("SoDienThoai", "0912345678"),
                    new XElement("LoaiKhach", "Thuong"),
                    new XElement("SoChuyenDaDi", "5")
                ),
                new XElement("KhachHang",
                    new XElement("Username", "khach2"),
                    new XElement("Password", "123"),
                    new XElement("SoDienThoai", "0912345679"),
                    new XElement("LoaiKhach", "VIP"),
                    new XElement("SoChuyenDaDi", "12")
                )
            );
            dsKhachHang.Save("KhachHang.xml");

            // Tạo XML cho tài xế
            XElement dsTaiXe = new XElement("DanhSachTaiXe",
                new XElement("TaiXe",
                    new XElement("Username", "taixe1"),
                    new XElement("Password", "123"),
                    new XElement("SoDienThoai", "0912345680"),
                    new XElement("MaSo", "TX001"),
                    new XElement("TenTaiXe", "Nguyễn Văn A"),
                    new XElement("HinhThucXe", "XeMay"),
                    new XElement("DoanhThuNgay", "1500000")
                ),
                new XElement("TaiXe",
                    new XElement("Username", "taixe2"),
                    new XElement("Password", "123"),
                    new XElement("SoDienThoai", "0912345681"),
                    new XElement("MaSo", "TX002"),
                    new XElement("TenTaiXe", "Nguyễn Văn B"),
                    new XElement("HinhThucXe", "OTo"),
                    new XElement("SoChoNgoi", "4"),
                    new XElement("DoanhThuNgay", "2500000")
                ),
                new XElement("TaiXe",
                    new XElement("Username", "taixe3"),
                    new XElement("Password", "123"),
                    new XElement("SoDienThoai", "0912345682"),
                    new XElement("MaSo", "TX003"),
                    new XElement("TenTaiXe", "Nguyễn Văn C"),
                    new XElement("HinhThucXe", "OToTai"),
                    new XElement("TrongTai", "5"),
                    new XElement("DoanhThuNgay", "3500000")
                )
            );
            dsTaiXe.Save("TaiXe.xml");

            // Tạo XML cho chuyến xe (sẽ tạo sau khi có dữ liệu khách hàng và tài xế)
        }

        static void DocDuLieuTuXML()
        {
            // Đọc dữ liệu khách hàng
            XElement dsKhachHang = XElement.Load("KhachHang.xml");
            foreach (var kh in dsKhachHang.Elements("KhachHang"))
            {
                TaiKhoanKhachHang tk = new TaiKhoanKhachHang(
                    kh.Element("Username").Value,
                    kh.Element("Password").Value,
                    kh.Element("SoDienThoai").Value
                );
                tk.LoaiKhach = kh.Element("LoaiKhach").Value;
                tk.SoChuyenDaDi = int.Parse(kh.Element("SoChuyenDaDi").Value);
                danhSachKhachHang.Add(tk);
            }

            // Đọc dữ liệu tài xế
            XElement dsTaiXe = XElement.Load("TaiXe.xml");
            foreach (var tx in dsTaiXe.Elements("TaiXe"))
            {
                TaiKhoanTaiXe tk = new TaiKhoanTaiXe(
                    tx.Element("Username").Value,
                    tx.Element("Password").Value,
                    tx.Element("SoDienThoai").Value,
                    tx.Element("MaSo").Value,
                    tx.Element("TenTaiXe").Value,
                    tx.Element("HinhThucXe").Value
                );

                if (tx.Element("SoChoNgoi") != null)
                    tk.SoChoNgoi = int.Parse(tx.Element("SoChoNgoi").Value);

                if (tx.Element("TrongTai") != null)
                    tk.TrongTai = int.Parse(tx.Element("TrongTai").Value);

                tk.DoanhThuNgay = decimal.Parse(tx.Element("DoanhThuNgay").Value);

                danhSachTaiXe.Add(tk);
            }

            // Tạo một số chuyến xe mẫu
            TaoChuyenXeMau();
        }

        static void TaoChuyenXeMau()
        {
            // Lấy các đối tượng từ danh sách
            var khach1 = danhSachKhachHang[0];
            var khach2 = danhSachKhachHang[1];
            var taiXe1 = danhSachTaiXe[0];
            var taiXe2 = danhSachTaiXe[1];
            var taiXe3 = danhSachTaiXe[2];

            // Tạo các chuyến xe mẫu
            ChuyenXe chuyen1 = new ChuyenXe(
                taiXe1, khach1, "123 Đường ABC", "456 Đường XYZ", 5,
                new DateTime(2023, 5, 1, 14, 0, 0)
            );

            ChuyenXe chuyen2 = new ChuyenXe(
                taiXe2, khach2, "789 Đường DEF", "101 Đường GHI", 10,
                new DateTime(2023, 5, 1, 15, 0, 0)
            );

            ChuyenXe chuyen3 = new ChuyenXe(
                taiXe3, khach1, "202 Đường KLM", "303 Đường NOP", 15,
                new DateTime(2023, 5, 1, 16, 0, 0)
            );

            ChuyenXe chuyen4 = new ChuyenXe(
                taiXe1, khach2, "404 Đường QRS", "505 Đường TUV", 3,
                new DateTime(2023, 5, 1, 22, 30, 0) // Chuyến đêm
            );

            danhSachChuyenXe.AddRange(new[] { chuyen1, chuyen2, chuyen3, chuyen4 });
        }

        // Các phương thức xử lý chức năng
        static void XuatTatCaDanhSach()
        {
            Console.WriteLine("=== DANH SÁCH KHÁCH HÀNG ===");
            foreach (var kh in danhSachKhachHang)
            {
                Console.WriteLine($"Username: {kh.Username}, SĐT: {kh.SoDienThoai}, Loại: {kh.LoaiKhach}, Số chuyến: {kh.SoChuyenDaDi}");
            }

            Console.WriteLine("\n=== DANH SÁCH TÀI XẾ ===");
            foreach (var tx in danhSachTaiXe)
            {
                Console.Write($"Mã: {tx.MaSo}, Tên: {tx.TenTaiXe}, Loại xe: {tx.HinhThucXe}");
                if (tx.HinhThucXe == "OTo") Console.Write($", Số chỗ: {tx.SoChoNgoi}");
                if (tx.HinhThucXe == "OToTai") Console.Write($", Trọng tải: {tx.TrongTai}tấn");
                Console.WriteLine($", Doanh thu: {tx.DoanhThuNgay}");
            }

            Console.WriteLine("\n=== DANH SÁCH CHUYẾN XE ===");
            foreach (var cx in danhSachChuyenXe)
            {
                Console.WriteLine($"Mã TX: {cx.TaiXe.MaSo}, Khách: {cx.KhachHang.Username}, " +
                    $"Đón: {cx.DiaChiDon}, Đến: {cx.DiaChiDen}, " +
                    $"Khoảng cách: {cx.KhoangCach}km, Thành tiền: {cx.ThanhTien}");
            }
        }

        static void NangCapKhachVIP()
        {
            foreach (var kh in danhSachKhachHang)
            {
                if (kh.SoChuyenDaDi >= 10 && kh.LoaiKhach != "VIP")
                {
                    kh.LoaiKhach = "VIP";
                    Console.WriteLine($"Đã nâng cấp khách {kh.Username} lên VIP");
                }
            }
        }

        static void DemSoXeMoiLoai()
        {
            int xeMay = danhSachTaiXe.Count(tx => tx.HinhThucXe == "XeMay");
            int oTo = danhSachTaiXe.Count(tx => tx.HinhThucXe == "OTo");
            int oToTai = danhSachTaiXe.Count(tx => tx.HinhThucXe == "OToTai");

            Console.WriteLine($"Số xe máy: {xeMay}");
            Console.WriteLine($"Số ô tô: {oTo}");
            Console.WriteLine($"Số ô tô tải: {oToTai}");
        }

        static void DemSoTaiKhoanKhach()
        {
            Console.WriteLine($"Tổng số tài khoản khách hàng: {danhSachKhachHang.Count}");
        }

        static void XuatTaiXeXeMay()
        {
            Console.WriteLine("=== DANH SÁCH TÀI XẾ XE MÁY ===");
            var dsTaiXeXeMay = danhSachTaiXe.Where(tx => tx.HinhThucXe == "XeMay");

            foreach (var tx in dsTaiXeXeMay)
            {
                Console.WriteLine($"Mã: {tx.MaSo}, Tên: {tx.TenTaiXe}, SĐT: {tx.SoDienThoai}, Doanh thu: {tx.DoanhThuNgay}");
            }
        }

        static void TinhTongDoanhThuTungLoai()
        {
            decimal doanhThuXeMay = danhSachTaiXe
                .Where(tx => tx.HinhThucXe == "XeMay")
                .Sum(tx => tx.DoanhThuNgay);

            decimal doanhThuOTo = danhSachTaiXe
                .Where(tx => tx.HinhThucXe == "OTo")
                .Sum(tx => tx.DoanhThuNgay);

            decimal doanhThuOToTai = danhSachTaiXe
                .Where(tx => tx.HinhThucXe == "OToTai")
                .Sum(tx => tx.DoanhThuNgay);

            Console.WriteLine($"Tổng doanh thu xe máy: {doanhThuXeMay}");
            Console.WriteLine($"Tổng doanh thu ô tô: {doanhThuOTo}");
            Console.WriteLine($"Tổng doanh thu ô tô tải: {doanhThuOToTai}");
        }

        static void XuatChuyenXeMayNhieuTienNhat()
        {
            var chuyenXeMay = danhSachChuyenXe
                .Where(cx => cx.TaiXe.HinhThucXe == "XeMay")
                .OrderByDescending(cx => cx.ThanhTien)
                .FirstOrDefault();

            if (chuyenXeMay != null)
            {
                Console.WriteLine("=== CHUYẾN XE MÁY CÓ TIỀN CƯỚC NHIỀU NHẤT ===");
                Console.WriteLine($"Mã TX: {chuyenXeMay.TaiXe.MaSo}, Khách: {chuyenXeMay.KhachHang.Username}");
                Console.WriteLine($"Đón: {chuyenXeMay.DiaChiDon}, Đến: {chuyenXeMay.DiaChiDen}");
                Console.WriteLine($"Khoảng cách: {chuyenXeMay.KhoangCach}km, Thành tiền: {chuyenXeMay.ThanhTien}");
            }
            else
            {
                Console.WriteLine("Không có chuyến xe máy nào trong danh sách");
            }
        }

        static void XuatChuyenOToNhieuTienNhat()
        {
            var chuyenOTo = danhSachChuyenXe
                .Where(cx => cx.TaiXe.HinhThucXe == "OTo")
                .OrderByDescending(cx => cx.ThanhTien)
                .FirstOrDefault();

            if (chuyenOTo != null)
            {
                Console.WriteLine("=== CHUYẾN Ô TÔ CÓ TIỀN CƯỚC NHIỀU NHẤT ===");
                Console.WriteLine($"Mã TX: {chuyenOTo.TaiXe.MaSo}, Khách: {chuyenOTo.KhachHang.Username}");
                Console.WriteLine($"Đón: {chuyenOTo.DiaChiDon}, Đến: {chuyenOTo.DiaChiDen}");
                Console.WriteLine($"Khoảng cách: {chuyenOTo.KhoangCach}km, Thành tiền: {chuyenOTo.ThanhTien}");
            }
            else
            {
                Console.WriteLine("Không có chuyến ô tô nào trong danh sách");
            }
        }

        static void XuatChuyenOToTaiNhieuTienNhat()
        {
            var chuyenOToTai = danhSachChuyenXe
                .Where(cx => cx.TaiXe.HinhThucXe == "OToTai")
                .OrderByDescending(cx => cx.ThanhTien)
                .FirstOrDefault();

            if (chuyenOToTai != null)
            {
                Console.WriteLine("=== CHUYẾN Ô TÔ TẢI CÓ TIỀN CƯỚC NHIỀU NHẤT ===");
                Console.WriteLine($"Mã TX: {chuyenOToTai.TaiXe.MaSo}, Khách: {chuyenOToTai.KhachHang.Username}");
                Console.WriteLine($"Đón: {chuyenOToTai.DiaChiDon}, Đến: {chuyenOToTai.DiaChiDen}");
                Console.WriteLine($"Khoảng cách: {chuyenOToTai.KhoangCach}km, Thành tiền: {chuyenOToTai.ThanhTien}");
            }
            else
            {
                Console.WriteLine("Không có chuyến ô tô tải nào trong danh sách");
            }
        }

        static void SapXepChuyenXe()
        {
            var dsSapXep = danhSachChuyenXe
                .OrderBy(cx => cx.ThanhTien)
                .ThenBy(cx => cx.TaiXe.MaSo)
                .ToList();

            Console.WriteLine("=== DANH SÁCH CHUYẾN XE ĐÃ SẮP XẾP ===");
            foreach (var cx in dsSapXep)
            {
                Console.WriteLine($"Mã TX: {cx.TaiXe.MaSo}, Tiền cước: {cx.ThanhTien}, " +
                    $"Khách: {cx.KhachHang.Username}, Khoảng cách: {cx.KhoangCach}km");
            }
        }

        static void XuatKhachHangVIP()
        {
            Console.WriteLine("=== DANH SÁCH KHÁCH HÀNG VIP ===");
            var dsVIP = danhSachKhachHang.Where(kh => kh.LoaiKhach == "VIP");

            foreach (var kh in dsVIP)
            {
                Console.WriteLine($"Username: {kh.Username}, SĐT: {kh.SoDienThoai}, Số chuyến: {kh.SoChuyenDaDi}");
            }
        }

        static void TimKhachHangNhieuChuyenNhat()
        {
            var khachNhieuChuyen = danhSachKhachHang
                .OrderByDescending(kh => kh.SoChuyenDaDi)
                .FirstOrDefault();

            if (khachNhieuChuyen != null)
            {
                Console.WriteLine("=== KHÁCH HÀNG CÓ NHIỀU CHUYẾN ĐI NHẤT ===");
                Console.WriteLine($"Username: {khachNhieuChuyen.Username}, SĐT: {khachNhieuChuyen.SoDienThoai}");
                Console.WriteLine($"Loại khách: {khachNhieuChuyen.LoaiKhach}, Số chuyến: {khachNhieuChuyen.SoChuyenDaDi}");
            }
        }

        static void TimTaiXeDoanhThuCaoNhat()
        {
            var taiXeTop = danhSachTaiXe
                .OrderByDescending(tx => tx.DoanhThuNgay)
                .FirstOrDefault();

            if (taiXeTop != null)
            {
                Console.WriteLine("=== TÀI XẾ CÓ DOANH THU CAO NHẤT ===");
                Console.WriteLine($"Mã: {taiXeTop.MaSo}, Tên: {taiXeTop.TenTaiXe}, Loại xe: {taiXeTop.HinhThucXe}");
                Console.WriteLine($"Doanh thu: {taiXeTop.DoanhThuNgay}, Phí công ty: {taiXeTop.TraPhiChoCongTy()}");
            }
        }

        static void XuatTaiXeOToDuocThuong()
        {
            Console.WriteLine("=== DANH SÁCH TÀI XẾ Ô TÔ ĐƯỢC THƯỞNG ===");
            var dsDuocThuong = danhSachTaiXe
                .Where(tx => tx.HinhThucXe == "OTo" && tx.DoanhThuNgay > 2000000);

            foreach (var tx in dsDuocThuong)
            {
                Console.WriteLine($"Mã: {tx.MaSo}, Tên: {tx.TenTaiXe}, Số chỗ: {tx.SoChoNgoi}");
                Console.WriteLine($"Doanh thu: {tx.DoanhThuNgay}, Thưởng: {tx.TinhThuong()}");
            }
        }

        static void XuatTaiXeOToTaiDuocThuong()
        {
            Console.WriteLine("=== DANH SÁCH TÀI XẾ Ô TÔ TẢI ĐƯỢC THƯỞNG ===");
            var dsDuocThuong = danhSachTaiXe
                .Where(tx => tx.HinhThucXe == "OToTai" && tx.DoanhThuNgay > 3000000);

            foreach (var tx in dsDuocThuong)
            {
                Console.WriteLine($"Mã: {tx.MaSo}, Tên: {tx.TenTaiXe}, Trọng tải: {tx.TrongTai}tấn");
                Console.WriteLine($"Doanh thu: {tx.DoanhThuNgay}, Thưởng: {tx.TinhThuong()}");
            }
        }
    }
}
