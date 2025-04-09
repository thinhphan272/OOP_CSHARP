using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4_OOP
{
    internal class CPhanSo
    {


        private int tuSo;
        private int mauSo;

        public CPhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }

        public CPhanSo() 
        {
            mauSo = 1;
        }

        public CPhanSo(CPhanSo obj)
        {
            this.tuSo = obj.tuSo;
            this.mauSo=obj.mauSo;
        }

        public CPhanSo cong(CPhanSo obj)
        {
            CPhanSo t = new CPhanSo();
            t.tuSo = this.tuSo * obj.mauSo + this.mauSo * obj.tuSo;
            t.mauSo = this.mauSo * obj.mauSo;

            return t;
        }

        public CPhanSo cong (int x)
        {
            CPhanSo t = new CPhanSo ();
            t.tuSo = x * this.mauSo + this.tuSo;
            t.mauSo = this.mauSo;
            return t;
        }

        public void xuatPS()
        {
            Console.WriteLine($"{tuSo} / {mauSo}");
        }
    }
}
