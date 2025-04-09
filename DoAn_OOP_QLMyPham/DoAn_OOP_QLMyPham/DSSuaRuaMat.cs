using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DoAn_OOP_QLMyPham
{
    public class DSSuaRuaMat : DSSanPham
    {
        private List<SuaRuaMat> lstSuaRuaMat;

        public List<SuaRuaMat> LstSuaRuaMat
        {
            get { return lstSuaRuaMat; }
            set { lstSuaRuaMat = value;}
        }

        public DSSuaRuaMat()
        {
            LstSuaRuaMat = new List<SuaRuaMat>();
        }

        public DSSuaRuaMat(List<SuaRuaMat> lstSuaRuaMat, List<SanPham> lstSanPham):base(lstSanPham)
        {
            LstSuaRuaMat = lstSuaRuaMat;
            
        }

        public override void XuatDSSP_Abstract()
        {
            base.XuatDSSP();
        }

        public override void NhapDSSP_Abstract()
        {
            base.NhapDSSP();
        }

        public void NhapDSSuaRuaMat_Xm(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);

            XmlNodeList nodelist = read.SelectNodes("/CuaHang/DSSanPham/DSSuaRuaMat/SuaRuaMat");

            foreach (XmlNode node in nodelist)
            {
                SuaRuaMat srm = new SuaRuaMat();
                srm.MaSP = node["MaSP"].InnerText;
                srm.TenSP = node["TenSP"].InnerText;
                srm.TrongLuong = float.Parse(node["TrongLuong"].InnerText);
                srm.GiaBan = double.Parse(node["GiaBan"].InnerText);
                srm.XuatXu = node["XuatXu"].InnerText;
                srm.NgaySX = DateTime.ParseExact(node["NgaySX"].InnerText, "dd/MM/yyyy", null);
                LstSuaRuaMat.Add(srm);
            }
        }
    }
}
