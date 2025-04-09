using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DoAn_OOP_QLMyPham
{
    public class DSKemChongNang : DSSanPham
    {
        private List<KemChongNang> lstKemChongNang;

        public List<KemChongNang> LstKemChongNang
        {
            get { return lstKemChongNang; }
            set { lstKemChongNang = value; }
        }

        public DSKemChongNang(List<KemChongNang> lstKemChongNang, List<SanPham> lstSanPham) : base(lstSanPham)
        {
            LstKemChongNang = lstKemChongNang;
        }
        public override void XuatDSSP_Abstract()
        {
            base.XuatDSSP();
        }

        public override void NhapDSSP_Abstract()
        {
            base.NhapDSSP();
        }

        public void NhapDSKemChongNang_Xml(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);

            XmlNodeList nodeList = read.SelectNodes("/CuaHang/DSSanPham/DSKemChongNang/KemChongNang");
            foreach (XmlNode node in nodeList) 
            {
                KemChongNang kcn = new KemChongNang();
                kcn.MaSP = node["MaSP"].InnerText;
                kcn.TenSP = node["TenSP"].InnerText;
                kcn.TrongLuong = float.Parse(node["TrongLuong"].InnerText);
                kcn.GiaBan = double.Parse(node["GiaBan"].InnerText);
                kcn.XuatXu = node["XuatXu"].InnerText;
                kcn.NgaySX = DateTime.ParseExact(node["NgaySX"].InnerText, "dd/MM/yyyy", null);
                LstKemChongNang.Add(kcn);
            }
        }
    }
}
