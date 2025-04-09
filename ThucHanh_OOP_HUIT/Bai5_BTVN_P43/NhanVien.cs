using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BTVN_P43
{
    internal class NhanVien
    {
        string maNV;

        public string MaNV
        {
            get
            {
                return maNV;

            }
            set
            { 
                maNV = value;
            }
        }    

        string hoTen;

        public string HoTen
        {
            get
            {
                return hoTen;

            }
            set
            {
                hoTen = value;
            }
        }
        string phongBan;

        public string PhongBan
        {
            get
            {
                return phongBan;

            }
            set
            {
                
                phongBan = value;
            }
        }
        string chucVu;

        public string ChucVu
        {
            get { return chucVu; }
            set
            {
                
                if (value == "Lanh dao" || value == "Nhan vien")
                {
                    chucVu = value;
                }
                else
                {
                    Console.WriteLine("Sai thông tin chức vụ !");
                    chucVu = "Nhan vien";
                }
            }
        }

        float heSoLuong;

        public float HeSoLuong
        {
            get
            {
                return heSoLuong;

            }
            set
            {

                heSoLuong = value;
            }
        }
        int thamNienCTac;

        public int ThamNienCTac
        {
            get
            {
                return thamNienCTac;

            }
            set
            {

                thamNienCTac = value;
            }
        }

        int soNgayLVcTrongThang;

        public int SoNgayLVcTrongThang
        {
            get
            {
                return soNgayLVcTrongThang;

            }
            set
            {

                soNgayLVcTrongThang = value;
            }
        }

        public NhanVien()
        {
            MaNV = null;
            HoTen = null;
            PhongBan = null;    
            ChucVu = "Nhan vien";
            HeSoLuong = 0.0f;
            ThamNienCTac = 0;
            SoNgayLVcTrongThang = 0;
        }    

        public NhanVien(string maNV, string hoTen, string phongBan, string chucVu, float heSoLuong, int thamNienCTac, int soNgayLVcTrongThang)
        {
            MaNV = maNV;
            HoTen = hoTen;
            PhongBan = phongBan;
            ChucVu = chucVu;
            HeSoLuong = heSoLuong;
            ThamNienCTac = thamNienCTac;
            SoNgayLVcTrongThang = soNgayLVcTrongThang;
        }    

        public NhanVien(NhanVien nv)
        {
            MaNV = nv.MaNV;
            HoTen = nv.HoTen;
            PhongBan = nv.PhongBan;
            ChucVu = nv.ChucVu;
            HeSoLuong = nv.HeSoLuong;
            ThamNienCTac = nv.ThamNienCTac;
            SoNgayLVcTrongThang = nv.SoNgayLVcTrongThang;
        }

        public static double LuongCoBan = 2340000;

        public static double PhuCapChucVu = 1350000;

        public float tinhHeSo_ThiDua()
        {
            if (ChucVu == "Lanh dao")
                return 1.0f;
            else 
            {
                if (SoNgayLVcTrongThang > 22)
                    return 1.0f;
                else if (SoNgayLVcTrongThang > 20)
                    return 0.8f;
                else
                    return 0.6f;
            }  
            

        }    

        public double tinhPhuCap()
        {
            if (ChucVu == "Lanh dao")
            {
                return PhuCapChucVu;
            }
            else
                return 0;
        }    

        public double tinhLuong()
        {
            return (double) HeSoLuong * LuongCoBan * tinhHeSo_ThiDua() + 1100000 + tinhPhuCap();
        }

        public void NhapNV()
        {
            Console.WriteLine("Nhập mã NV: ");
            MaNV = Console.ReadLine();
            Console.WriteLine("Họ tên NV: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Phòng ban: ");
            PhongBan = Console.ReadLine();
            Console.WriteLine("Chức vụ: ");
            ChucVu = Console.ReadLine().Trim();
            Console.WriteLine("Hệ số lương: ");
            HeSoLuong = float.Parse(Console.ReadLine());
            Console.WriteLine("Thâm niên công tác: ");
            ThamNienCTac = int.Parse(Console.ReadLine());
            Console.WriteLine("Số ngày làm việc trong tháng: ");
            SoNgayLVcTrongThang = int.Parse(Console.ReadLine());
        }

        public void XuatNV()
        {
            Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8} |",
                MaNV.PadRight(6),
                HoTen.PadRight(20),
                PhongBan.PadRight(10),
                ChucVu.PadRight(10),
                HeSoLuong.ToString("0.0").PadRight(7),
                ThamNienCTac.ToString().PadRight(7),
                SoNgayLVcTrongThang.ToString().PadRight(5),
                tinhLuong().ToString("0.0").PadRight(10),
                tinhHeSo_ThiDua().ToString("0.0").PadRight(7)
                ); 
        }    

    }
}
