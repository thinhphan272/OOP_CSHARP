using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ThucHanh_Buoi4_OOP_HUIT
{
    internal class CongTyABC
    {
        string tenCty;
        string diaChi;
        string sdt;

        List<NhanVien> lstNhanVien = new List<NhanVien>();

        public List<NhanVien> LstNhanVien
        { 
            get { return lstNhanVien; }
            set { lstNhanVien = value; }
        }

        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string TenCty { get => tenCty; set => tenCty = value; }

        public CongTyABC()
        {

        }
        public CongTyABC(string tenCty, string diaChi, string sdt, List<NhanVien> lstNhanVien)
        {

        }

        public void Nhap_XML(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);

            TenCty = read.SelectSingleNode("/CongTy/TenCty").InnerText;
            DiaChi = read.SelectSingleNode("/CongTy/DiaChi").InnerText;
            Sdt = read.SelectSingleNode("/CongTy/DT").InnerText;

            XmlNodeList nodeList = read.SelectNodes("/CongTy/DSNV/NV");
            foreach (XmlNode node in nodeList) 
            {
                int l = int.Parse(node.Attributes["loai"].Value);
                if(l == 1)
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNV = node["MaNV"].InnerText;
                    nv.TenNV = node["TenNV"].InnerText;
                    nv.NamVL = int.Parse(node["NamVaoLam"].InnerText);
                    nv.HeSoLG = double.Parse(node["HeSoLuong"].InnerText);
                    nv.SoNN = int.Parse(node["SoNgayNghi"].InnerText);
                    
                }    
            }
            
        }


    }
}
