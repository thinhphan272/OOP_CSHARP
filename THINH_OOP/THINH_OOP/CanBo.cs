using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THINH_OOP
{
    internal class CanBo : NhanVienABC
    {
        private string chucVu;
        private double heSoCV;

        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }    

        public double HeSoCV
        {
            get { return heSoCV; }
            set { heSoCV = value; }
        }    
        public CanBo() :base() { }

        public CanBo(string chucVu, double heSoCV, string maNV, string tenNV, int namSinh, string gioiTinh, double heSoLg, int namVL) : base(maNV, tenNV, namSinh, gioiTinh, heSoLg, namVL)
        {
            ChucVu = chucVu;
            HeSoCV = heSoCV;
        }

        public override double Luong()
        {
            return HeSoLg * LuongCB + (HeSoCV * 1350);
        }
        public override char XepLoai()
        {
            return 'A';
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Chức vụ: {0}\nHệ số CV: {1}", ChucVu, HeSoCV);

        }
    }
}
