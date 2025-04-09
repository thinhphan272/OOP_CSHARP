using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh_OOP_HUIT
{
    internal class Lst_PhanSo
    {
        List<PhanSo> lstPhanSo = new List<PhanSo>();
        public List<PhanSo> LstPhanSo
        {
            get
            {
                return lstPhanSo;
            }
            set
            {
                lstPhanSo = value;
            }
        }

        public Lst_PhanSo()
        {
            LstPhanSo = new List<PhanSo>();
        }

        public Lst_PhanSo(List<PhanSo> lstPhanSo)
        {
            this.LstPhanSo = lstPhanSo;
        }

        public void NhapDS()
        {
            Console.WriteLine("Nhập số phần tử của danh sách: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập phân số thứ {0}", i +1);
                PhanSo x = new PhanSo();
                x.Nhap();
                LstPhanSo.Add(x);
            }    
        }

        public void XuatDS()
        {
            foreach(PhanSo x in LstPhanSo)
            {
                x.Xuat();
            }    
        }

        public void ToiGianDS()
        {
            foreach (PhanSo x in LstPhanSo)
            {
                x.ToiGian();
            }    
        }

        //kiểm tra phân số nhập từ bàn phím có không danh sách phân số không 
        public bool SearchPS (PhanSo p)
        {
            PhanSo k = LstPhanSo.Find(t => t.GiaTriThuc == p.GiaTriThuc);
            if (k == null)
                return false;
            return true;
        }

        //sắp xếp danh sách phân số tăng dần

        public Lst_PhanSo sortGiaTri()
        {
            Lst_PhanSo lst1 = new Lst_PhanSo();
            lst1.LstPhanSo = LstPhanSo.OrderBy(t => t.GiaTriThuc).ToList();
            return lst1;
        }

        //Tìm danh sách con trong ds cha thỏa điều kiện: giá trị thực > 1

        public Lst_PhanSo LocDuLieu()
        {
            Lst_PhanSo lst1 = new Lst_PhanSo();
            lst1.LstPhanSo = LstPhanSo.Where(t => t.TuSo > t.MauSo).ToList();
            return lst1;
        }

        //Tìm phân số lớn nhất

        public PhanSo ps_max()
        {
            float max = LstPhanSo.Max(t => t.GiaTriThuc);
            return LstPhanSo.FirstOrDefault(x =>  x.GiaTriThuc == max);
        }

        //Tìm 3 phân số có giá trị thực lớn nhất 

        public Lst_PhanSo Top3Ps()
        {
            Lst_PhanSo lst1 = new Lst_PhanSo();

            lst1.LstPhanSo = LstPhanSo.OrderByDescending(t => t.GiaTriThuc).Take(3).ToList();
            return lst1;
        }
    }
}
