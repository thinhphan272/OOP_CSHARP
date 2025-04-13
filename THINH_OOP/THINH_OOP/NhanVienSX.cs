using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THINH_OOP
{
    internal class NhanVienSX : NhanVienABC
    {
        public static double HSPC_NN = 0.1;
        private int soNN;

        public int SoNN
        {
            get { return soNN; }
            set { soNN = value; }
        }    
        public NhanVienSX():base() { }

        public NhanVienSX(int soNN, string maNV, string tenNV, int namSinh, string gioiTinh, double heSoLg, int namVL):base(maNV, tenNV, namSinh, gioiTinh, heSoLg, namVL)
        {
            SoNN = soNN;
        }    

        public override double Luong()
        {
            return (double)HeSoLg * LuongCB * (1 + HSPC_NN);
        }

        public override char XepLoai()
        {
            if (SoNN <= 1)
                return 'A';
            else if (SoNN <= 3)
                return 'B';
            else if (SoNN <= 5)
                return 'C';
            else
                return 'D';
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Số ngày nghỉ: {0}\n", SoNN);
        }
    }
}
