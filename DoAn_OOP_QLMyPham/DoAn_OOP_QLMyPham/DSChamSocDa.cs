using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DoAn_OOP_QLMyPham
{
    public class DSChamSocDa : DSSanPham
    {
        private List<ChamSocDa> lstChamSocDa;

        public List<ChamSocDa> LstChamSocDa
        {
            get { return lstChamSocDa; }
            set { lstChamSocDa = value; }
        }

        public DSChamSocDa()
        {
            LstChamSocDa = new List<ChamSocDa>();
        }

        public DSChamSocDa(List<ChamSocDa> lstChamSocDa, List<SanPham> lstSanPham):base(lstSanPham)
        {
            LstChamSocDa = lstChamSocDa;
        }

        public override void XuatDSSP_Abstract()
        {
            base.XuatDSSP();
        }

        public override void NhapDSSP_Abstract()
        {
            base.NhapDSSP();
        }

        public void NhapDSChamSocDa_Xml(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);

            XmlNodeList nodeList = read.SelectNodes("/CuaHang/DSSanPham/DSChamSocDa/ChamSocDa");
            foreach (XmlNode node in nodeList)
            {
                ChamSocDa csd = new ChamSocDa();
                csd.MaSP = node["MaSP"].InnerText;
                csd.TenSP = node["TenSP"].InnerText;
                csd.TrongLuong = float.Parse(node["TrongLuong"].InnerText);
                csd.GiaBan = double.Parse(node["GiaBan"].InnerText);
                csd.XuatXu = node["XuatXu"].InnerText;
                csd.NgaySX = DateTime.ParseExact(node["NgaySX"].InnerText, "dd/MM/yyyy", null);
                LstChamSocDa.Add(csd);
            }
        }
    }
}
