using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THINH_OOP
{
    public abstract class NhanVienABC
    {
        protected string maNV;
        protected string tenNV;
        protected int namSinh;
        protected string gioiTinh;
        protected double heSoLg;
        protected int namVL;

        public string MaNV
        {
            get { return maNV;}
            set { maNV = value;}
        }
        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        public int NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public double HeSoLg
        {
            get { return heSoLg; }
            set { heSoLg = value; }
        }

        public int NamVL
        {
            get { return namVL; }
            set
            {
                namVL = value;
                if(namVL > DateTime.Today.Year)
                {
                    namVL = DateTime.Today.Year;
                }
            }
        }

        public NhanVienABC()
        {
            MaNV = "NV000";
            TenNV = "Chua biet";
            NamSinh = 0;
            GioiTinh = "Chua biet";
            HeSoLg = 0;
            NamVL = 0;
        }

        public NhanVienABC(string maNV, string tenNV, int namSinh, string gioiTinh, double heSoLg, int namVL)
        {
            MaNV = maNV;
            TenNV = tenNV;
            NamSinh = namSinh;
            GioiTinh = gioiTinh;
            HeSoLg = heSoLg;
            NamVL = namVL;
        }

        public abstract char XepLoai();

    }
}
