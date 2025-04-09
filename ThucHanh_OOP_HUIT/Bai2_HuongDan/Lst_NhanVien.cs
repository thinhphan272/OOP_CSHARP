using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_HuongDan
{
    internal class Lst_NhanVien
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
        public Lst_NhanVien()
        {
            LstNhanVien = new List<NhanVien>();
        }

        public Lst_NhanVien(List<NhanVien> lstNhanVien)
        {
            this.LstNhanVien = lstNhanVien;
        }

        

       //Tìm nhân viên có lương cao nhất

        public NhanVien Max_Luong_NV()
        {
            double max = LstNhanVien.Max(t => t.TinhLuong_Moi_NV());

            return LstNhanVien.FirstOrDefault(x => x.TinhLuong_Moi_NV() == max);
        }

        //Tính tổng lương tất cả nhân viên

        public double TongLuong_NV()
        {
            return LstNhanVien.Sum(t => t.TinhLuong_Moi_NV());

        }


        //Sắp xếp danh sách nhân viên tăng dần

        public Lst_NhanVien sortIncreasing()
        {
            Lst_NhanVien lst = new Lst_NhanVien();
            lst.LstNhanVien = LstNhanVien.OrderBy(t => t.NamVaoLam).ToList();
            return lst;
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
            foreach (NhanVien x in LstNhanVien)
            {
                x.XuatNV();
            }    
        }    
    }
}
