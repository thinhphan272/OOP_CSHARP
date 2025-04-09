using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoAn_OOP_QLMyPham
{
    public abstract class SanPham
    {
        protected string maSP;
        public string MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }
        protected string tenSP;

        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }

        protected double trongLuong;


        public double TrongLuong
        {
            get { return trongLuong; }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Trọng lượng không được nhỏ hơn 0!!");
                }    
                else
                    trongLuong = value;
            }
        }

        protected double giaBan;

        public double GiaBan
        {
            get { return giaBan;}
            set
            {
                if(value < 0) 
                {
                    throw new Exception("Giá bán không được nhỏ hơn 0!!");
                }
                else
                    giaBan = value;
            }
        }
        protected string xuatXu;

        public string XuatXu
        {
            get { return xuatXu; }
            set { xuatXu = value; }
        }
        protected DateTime ngaySX;

        public DateTime NgaySX
        {
            get { return ngaySX; }
            set 
            { 
                if(value > DateTime.Now)
                {
                    throw new Exception("Ngày sản xuất không thể lớn hơn ngày hiện tại !!");
                }   
                else
                    ngaySX = value;
            }
        }

        //Khởi tạo mặc định cho SẢN PHẨM

        public SanPham()
        {
            MaSP = "Chưa có mã sản phẩm";
            TenSP = "Chưa có tên sản phẩm";
            TrongLuong = 0;
            GiaBan = 0;
            XuatXu = "Chưa có thông tin xuất xứ";
            NgaySX = DateTime.Now;

        }

        //Khởi tạo đầy đủ tham số cho SẢN PHẨM
        public SanPham(string maSP, string tenSP, double trongLuong, double giaBan, string xuatXu, DateTime ngaySX)
        {
            MaSP = maSP;
            TenSP = tenSP;
            TrongLuong = trongLuong;
            GiaBan = giaBan;
            XuatXu = xuatXu;
            NgaySX = ngaySX;
        }

        //Khởi tạo sao chép cho SẢN PHẨM
        public SanPham(SanPham sp)
        {
            MaSP = sp.MaSP;
            TenSP = sp.TenSP;
            TrongLuong = sp.TrongLuong;
            GiaBan = sp.GiaBan;
            XuatXu = sp.XuatXu;
            NgaySX = sp.NgaySX;
        }


        //Phương thức nhập abstract
        public abstract void NhapSP();


        //Phương thức nhập sản phẩm 
        public void nhap()
        {
            Console.WriteLine("Nhập mã sản phẩm: ");
            MaSP = Console.ReadLine();
            Console.WriteLine("Nhập tên sản phẩm: ");
            TenSP = Console.ReadLine();
            Console.WriteLine("Nhập trọng lượng: ");
            TrongLuong = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập giá bán: ");
            GiaBan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập xuất xứ: ");
            XuatXu = Console.ReadLine();
            Console.Write("Nhập ngày sản xuất (dd/MM/yyyy): ");
            
            string dinhDang = "dd/MM/yyyy"; // Định dạng mong muốn

            while (!DateTime.TryParseExact(Console.ReadLine(), dinhDang, null, System.Globalization.DateTimeStyles.None, out ngaySX) || ngaySX > DateTime.Now)
            {
                Console.WriteLine("Lỗi! Hãy nhập đúng định dạng (dd/MM/yyyy).");
                Console.Write("Nhập lại: ");
            }

            Console.WriteLine($"Ngày sản xuất: {NgaySX:dd/MM/yyyy}");
        }



        //Phương thức xuất abstract
        public abstract void XuatSP();


        //Phương thức xuất sản phẩm 
        public void xuat()
        {
            Console.WriteLine("| {0, -7} | {1, -23} | {2, -7} gam | {3, -7}VND | {4, -7} | {5, -10} |", MaSP, TenSP, TrongLuong.ToString("0.0"), GiaBan, XuatXu, NgaySX.ToString("dd/MM/yyyy"));
        }

    }
}