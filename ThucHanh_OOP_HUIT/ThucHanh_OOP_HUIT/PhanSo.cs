using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh_OOP_HUIT
{
    internal class PhanSo
    {
        int tuSo;

        public int TuSo
        {
            get
            {
                return tuSo;
            }
            set 
            {
                tuSo = value;
            }
        }
        int mauSo;

        public int MauSo
        {
            get
            {
                return mauSo;
            }
            set
            {
                if(value == 0)
                {
                    Console.WriteLine("Mẫu số phải khác 0");
                    mauSo = 1;
                }
                else
                    mauSo = value;
            }
        }

        public float GiaTriThuc
        {
            get
            {
                return (float)TuSo / MauSo;
            }
        }

        public PhanSo()
        {
            TuSo = 0;
            MauSo = 1;
        }

        public PhanSo(int tuSo, int mauSo)
        {
            this.TuSo = tuSo;
            this.mauSo = mauSo;
        }

        public PhanSo(PhanSo ps)
        {
            this.TuSo = ps.TuSo;
            this.MauSo = ps.MauSo;
        }

        public void ToiGian()
        {
            int uocChung = TienIch.TimUCLN(TuSo, MauSo);

            TuSo /= uocChung;
            MauSo /= uocChung;
        }

        public PhanSo TinhTong(PhanSo p)
        {
            PhanSo psTong = new PhanSo();
            psTong.TuSo = this.TuSo * p.MauSo + p.TuSo * this.MauSo;
            psTong.MauSo = this.MauSo * p.MauSo;
            psTong.ToiGian();
            return psTong;
        }

        public PhanSo TinhTong(int x)
        {
            return this.TinhTong(new PhanSo(x, 1));
        }

        public void Nhap()
        {
            Console.WriteLine("Nhập tử số: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập mẫu số: ");
            MauSo = int.Parse(Console.ReadLine());


        }

        public void Xuat()
        {
            Console.WriteLine("{0} / {1}", TuSo, MauSo);
        }
    }
}
