using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace THINH_OOP
{
    internal class CongTyABC
    {
        private string tenCTY;
        private string diaChi;
        private string sdt;
        private List<NhanVienABC> lstNhanVien = new List<NhanVienABC>();

        public string TenCTY
        {
            get { return tenCTY; }
            set { tenCTY = value; }
        }    

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }    

        public string Sdt
        {
            get { return sdt;}
            set { sdt = value; }
        }    

        public List<NhanVienABC> LstNhanVien
        {
            get { return lstNhanVien; }
            set { lstNhanVien = value; }
        }

        public CongTyABC()
        {

        }    

        public CongTyABC(string tenCTY, string diaChi, string sdt, List<NhanVienABC> lstNhanVien)
        {
            TenCTY = tenCTY;
            DiaChi = diaChi;
            Sdt = sdt;
            LstNhanVien = lstNhanVien;
        }    


        public void Nhap_XML(string file)
        {
            Console.InputEncoding = Encoding.UTF8;
            XmlDocument read = new XmlDocument();
            read.Load(file);

            TenCTY = read.SelectSingleNode("/CongTy/TenCTY").InnerText;
            DiaChi = read.SelectSingleNode("/CongTy/DiaChi").InnerText;
            Sdt = read.SelectSingleNode("/CongTy/SDT").InnerText;

            XmlNodeList nodeList = read.SelectNodes("/CongTy/NhanVien");
            foreach(XmlNode node in nodeList)
            {
                NhanVienABC nv;
                int l = int.Parse(node["Loai"].InnerText);
                string maNV = node["MaNV"].InnerText;
                string tenNV = node["TenNV"].InnerText;
                int namSinh = int.Parse(node["NamSinh"].InnerText);
                string gioiTinh = node["GioiTinh"].InnerText;
                double heSoLg = double.Parse(node["HeSoLuong"].InnerText);
                int namVL = int.Parse(node["NamVL"].InnerText);

                if (l == 1)
                {
                    
                    int soNN = int.Parse(node["SoNN"].InnerText);
                    nv = new NhanVienSX(soNN,maNV, tenNV, namSinh, gioiTinh, heSoLg, namVL);

                }   
                else if(l == 2) 
                {
                    double ds_toiThieu = double.Parse(node["DSToiThieu"].InnerText);
                    double ds_thucTe = double.Parse(node["DSThucTe"].InnerText);
                    nv = new NhanVienKD(ds_toiThieu, ds_thucTe, maNV, tenNV, namSinh, gioiTinh, heSoLg, namVL);

                }

                else
                {
                    string chucVu = node["ChucVu"].InnerText;
                    double heSoCV = double.Parse(node["HeSoCV"].InnerText);
                    nv = new CanBo(chucVu, heSoCV, maNV, tenNV, namSinh, gioiTinh, heSoLg, namVL);
                }

                LstNhanVien.Add(nv);
            }    


        }

        public double TongThuNhap()
        {
            return LstNhanVien.Sum(t => t.thuNhap());
        }    


        public void XuatDS()
        {
            Console.WriteLine("Tên công ty: {0}", TenCTY);
            Console.WriteLine("Địa chỉ: {0}", DiaChi);
            Console.WriteLine("Liên hệ: {0}", Sdt);
            Console.WriteLine("---------------------------------------------------------BẢNG DANH SÁCH NHÂN VIÊN--------------------------------------------");
            Console.WriteLine("| {0, -10} | {1, -20} | {2, -10} | {3, -10} | {4, -15} | {5, -15} | {6, -10} | {7, -10} |", "Mã NV","Tên NV", "Năm Sinh", "Giới Tính", "Hệ Số Lương", "Năm Vào Làm", "Xếp Loại", "Tiền Lương");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");

            foreach (NhanVienABC nv in LstNhanVien)
            {
                nv.Xuat();
            }
            
        }    
    }
}
