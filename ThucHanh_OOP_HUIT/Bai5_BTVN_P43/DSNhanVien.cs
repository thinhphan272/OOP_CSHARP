using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_BTVN_P43
{
    internal class DSNhanVien
    {
        List<NhanVien> lstNhanVien = new List<NhanVien>();

        public List<NhanVien> LstNhanVien
        {
            get
            {
                return lstNhanVien;
            }
            set
            {
                lstNhanVien = value;
            }
        }
        public DSNhanVien()
        {
            LstNhanVien = new List<NhanVien>();
        }

        public DSNhanVien(List<NhanVien> lstNhanVien)
        {
            LstNhanVien = lstNhanVien;
        }

        public DSNhanVien(DSNhanVien lst)
        {
            LstNhanVien = lst.LstNhanVien;
        }

        public DSNhanVien LocDulieu_1()
        {
            DSNhanVien lst = new DSNhanVien();
            lst.LstNhanVien = LstNhanVien.Where(t => t.tinhHeSo_ThiDua() == 1.0f).ToList();
            return lst;
        }

        public DSNhanVien LocDulieu_08()
        {
            DSNhanVien lst = new DSNhanVien();
            lst.LstNhanVien = LstNhanVien.Where(t => t.tinhHeSo_ThiDua() == 1.0f).ToList();
            return lst;
        }

        public DSNhanVien LocDulieu_06()
        {
            DSNhanVien lst = new DSNhanVien();
            lst.LstNhanVien = LstNhanVien.Where(t => t.tinhHeSo_ThiDua() == 1.0f).ToList();
            return lst;
        }
        public void xuatDS_TheoHSTDua()
        {

            Console.WriteLine("\nDanh sách nhân viên theo Hệ Số thi đua 1.0");
            foreach (var NhanVien in LstNhanVien)
            {
                if (NhanVien.tinhHeSo_ThiDua() == 1.0f)
                {
                    NhanVien.XuatNV();
                }    
            }

            Console.WriteLine("\nDanh sách nhân viên theo Hệ Số thi đua 0.8");
            foreach (var NhanVien in LstNhanVien)
            {
                if (NhanVien.tinhHeSo_ThiDua() == 0.8f)
                {
                    NhanVien.XuatNV();
                }
            }

            Console.WriteLine("\nDanh sách nhân viên theo Hệ Số thi đua 0.6");
            foreach (var NhanVien in LstNhanVien)
            {
                if (NhanVien.tinhHeSo_ThiDua() == 0.6f)
                {
                    NhanVien.XuatNV();
                }
            }



        }

        public void xuatNV_theoPhongBan(string phongBan)
        {
            Console.WriteLine("\nDanh sách nhân viên theo phòng ban cho trước");
            foreach (var NhanVien in LstNhanVien)
            {
                if (NhanVien.PhongBan == phongBan)
                {
                    NhanVien.XuatNV();
                }
            }
        }

        public void xuatNV_LanhDao()
        {
            Console.WriteLine("\nDanh sách Lãnh đạo");
            foreach (var NhanVien in LstNhanVien)
            {
                if (NhanVien.ChucVu == "Lanh dao")
                {
                    NhanVien.XuatNV();
                }
            }
        }

        

        public double TongLuong_NV()
        {
            return LstNhanVien.Sum(t => t.tinhLuong());
        }

        public void XoaNV_WorkLess10D()
        {
            NhanVien x = LstNhanVien.FirstOrDefault(t => t.SoNgayLVcTrongThang < 10);
            if (x != null) 
            {
                LstNhanVien.Remove(x);
            }
        }    

        public void xuatNV_NotLanhDao_WorkMore22D()
        {
            Console.WriteLine("\nDanh sách nhân viên không phải lãnh đạo có số ngày làm việc > 22");
            foreach (var NhanVien in LstNhanVien)
            {
                if (NhanVien.ChucVu != "Lanh dao" && NhanVien.SoNgayLVcTrongThang > 22)
                {
                    NhanVien.XuatNV();
                }
            }
        }

        public void xuatNV_HSLMore4_34_TaiVu()
        {
            Console.WriteLine("\nDanh sách các nhân viên có hệ số lương từ 4.34 trở lên và làm ở phòng Tài vụ: ");
            foreach (var NhanVien in LstNhanVien)
            {
                if (NhanVien.PhongBan == "Tai vu" && NhanVien.HeSoLuong > 4.34f)
                {
                    NhanVien.XuatNV();
                }
            }
        }

        public void NhapDS()
        {
            Console.WriteLine("Nhập số lượng nhân viên: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++) 
            {
                Console.WriteLine("Nhập nhân viên thứ {0}", i + 1);
                NhanVien x = new NhanVien();
                x.NhapNV();
                LstNhanVien.Add(x);
            }
        }    

        public void XuatDS()
        {
            foreach(NhanVien x in LstNhanVien)
            {
                x.XuatNV();
            }    
        }    


    }
}
