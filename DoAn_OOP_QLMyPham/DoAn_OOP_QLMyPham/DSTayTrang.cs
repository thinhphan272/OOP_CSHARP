using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace DoAn_OOP_QLMyPham
{
    public class DSTayTrang : DSSanPham
    {
        private List<TayTrang> lstTayTrang;

        public List<TayTrang> LstTayTrang
        {
            get { return lstTayTrang; }
            set { lstTayTrang = value; }
        }

        public DSTayTrang()
        {
            LstTayTrang = new List<TayTrang>();
        }

        public DSTayTrang(List<TayTrang> lstTayTrang, List<SanPham> lstSanPham):base(lstSanPham)
        {
            LstTayTrang = lstTayTrang;
        }

        public override void XuatDSSP_Abstract()
        {
            base.XuatDSSP();
        }

        public override void NhapDSSP_Abstract()
        {
            base.NhapDSSP();
        }

        public void NhapDSTayTrang_Xm(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);

            XmlNodeList nodelist = read.SelectNodes("/CuaHang/DSSanPham/DSTayTrang/TayTrang");

            foreach(XmlNode node in nodelist) 
            {
                TayTrang tt = new TayTrang();
                tt.MaSP = node["MaSP"].InnerText;
                tt.TenSP = node["TenSP"].InnerText;
                tt.TrongLuong = float.Parse(node["TrongLuong"].InnerText);
                tt.GiaBan = double.Parse(node["GiaBan"].InnerText);
                tt.XuatXu = node["XuatXu"].InnerText;
                tt.NgaySX = DateTime.ParseExact(node["NgaySX"].InnerText, "dd/MM/yyyy", null);
                LstTayTrang.Add(tt);
            }

        }
    }

}