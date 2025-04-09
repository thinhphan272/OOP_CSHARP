using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh_Buoi4_OOP_HUIT
{
    internal class CanBo:NhanVien
    {
        string chucVu;
        string phongBan;
        double heSOPCLD;

        public string ChucVu
        { 
            get => chucVu;
            set
            {
                //if (value.ToLower() != "giam doc" || value.ToLower() != "pho giam doc" || value.ToLower() != "truong phong" || value.ToLower() != "pho phong")
                List<string> list = new List<string> {"giam doc", "pho giam doc", "truong phong", "pho phong" };
                if(!list.Contains(value))
                    throw new Exception("Sai cú pháp chức vụ!");
                else
                    chucVu = value;
            }
        }

        public string PhongBan { get => phongBan; set => phongBan = value; }
        public double HeSOPCLD { get => heSOPCLD; set => heSOPCLD = value; }

        public CanBo():base()
        {
            ChucVu = "Truong phong";
            PhongBan = "Hanh chinh";
            HeSOPCLD = 5.0;

        }

        public CanBo(string maNV, string tenNV, double heSoLG, string chucVu, double heSOPCLD):base(maNV, tenNV, DateTime.Today.Year, heSoLG, 1)
        {
            
            ChucVu = chucVu;
            PhongBan = "Hanh chinh";
            HeSOPCLD = heSOPCLD;
        }

        public CanBo(string chucVu, string phongBan, double heSOPCLD, string maNV, string tenNV, int namVL, double heSoLG, int soNN):base(maNV, tenNV, namVL, heSoLG, soNN)
        {
            ChucVu = chucVu;
            PhongBan = phongBan;
            HeSOPCLD = heSOPCLD;
        }

        public override char XepLoai()
        {
            return 'A';
        }

        public double tinhPCLD()
        {
            return (double)heSOPCLD * LuongCB;
        }

        public override double tinhLuong()
        {
            return base.tinhLuong() + tinhPCLD();
        }

        public void XuatCB()
        {
            base.XuatNV();
            Console.WriteLine("Chức vụ: {0}\nPhòng ban: {1}\nHệ số phụ cấp lãnh đạo: {2}", ChucVu, PhongBan, HeSoLG);
        }
    }
}
