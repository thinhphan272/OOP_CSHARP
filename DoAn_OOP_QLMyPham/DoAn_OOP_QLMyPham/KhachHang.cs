using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoAn_OOP_QLMyPham
{
    public class KhachHang
    {
        private string maKH;

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        private string tenKH;

        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }


        private long soDienThoai;

        public long SoDienThoai
        {
            get { return soDienThoai; }
            set {  soDienThoai = value; }
        }
        private List<SanPham> lstSanPhamDaMua;

        public List<SanPham> LstSanPhamDaMua
        {
            get { return lstSanPhamDaMua; }
            set { lstSanPhamDaMua = value; }
        }

        public KhachHang()
        {
            MaKH = "Chua co ma khach hang!";
            TenKH = "Chua co ten khach hang!";
            soDienThoai = 0;
            LstSanPhamDaMua = new List<SanPham>();
        }
        public KhachHang(string maKH, string tenKH, long soDienThoai, List<SanPham> lstSanPhamDaMua)
        {
            MaKH = maKH;
            TenKH = tenKH;
            SoDienThoai = soDienThoai;
            LstSanPhamDaMua = lstSanPhamDaMua; ;
        }

        public KhachHang(KhachHang kh)
        {
            MaKH = kh.MaKH;
            TenKH = kh.TenKH;
            SoDienThoai = kh.SoDienThoai;
            LstSanPhamDaMua = kh.LstSanPhamDaMua;
        }
        public void NhapKH()
        {
            Console.WriteLine("Nhập mã khách hàng: ");
            MaKH = Console.ReadLine();
            Console.WriteLine("Nhập tên khách hàng: ");
            TenKH = Console.ReadLine();
            Console.WriteLine("Nhập số điện thoại khách hàng: ");
            SoDienThoai = long.Parse(Console.ReadLine());

            Console.WriteLine("Nhập số lượng sản phẩm đã mua: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập sản phẩm thứ {0}:\n1 - KEM CHỐNG NẮNG\n2 - TẨY TRANG\n3 - SỬA RỬA MẶT\n4 - TRANG ĐIỂM\n5 - CHĂM SÓC DA", i + 1);
                int loaiSP = int.Parse(Console.ReadLine());

                SanPham sp = null;
                switch(loaiSP) 
                {
                    case 1:
                        sp = new KemChongNang();
                        break;
                    case 2:
                        sp = new TayTrang();
                        break;
                    case 3:
                        sp = new SuaRuaMat();
                        break;
                    case 4:
                        sp = new TrangDiem();
                        break;
                    case 5:
                        sp = new ChamSocDa();
                        break;
                }

                if(sp != null)
                {
                    sp.NhapSP();
                    LstSanPhamDaMua.Add(sp);
                }    
            }    

        }

        

        public void XuatKH()
        {
            Console.Write("------------------------------------------------");
            Console.Write("\n| {0, -5} | {1, -23} | {2, -10} |", "Mã KH", "Tên KH", "SĐT");
            Console.Write("\n------------------------------------------------");
            Console.Write("\n| {0, -5} | {1, -23} | {2, -10} |", MaKH, TenKH, SoDienThoai.ToString("D10"));
            Console.WriteLine("\n------------------------------------------------");

            Console.WriteLine("\n----------------------------DANH SÁCH SẢN PHẨM ĐÃ MUA----------------------------------");
            Console.WriteLine("| {0, -7} | {1, -23} | {2, -9} | {3, -10} | {4, -7} | {5, -10} |",
    "Mã SP", "Tên Sản Phẩm", "Trọng Lượng", "Giá Bán", "Xuất Xứ", "Ngày SX");
            if (LstSanPhamDaMua == null || LstSanPhamDaMua.Count == 0)
            {
                Console.WriteLine("Danh sách sản phẩm đã mua trống");
            }   
            else
            {
                foreach (SanPham x in LstSanPhamDaMua)
                {
                    x.XuatSP();
                }
            }    
           
            Console.WriteLine("\n---------------------------------------------------------------------------------------");

        }
    }
}