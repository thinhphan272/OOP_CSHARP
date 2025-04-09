using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DoAn_OOP_QLMyPham
{
    public class DSTrangDiem : DSSanPham
    {
        private List<TrangDiem> lstTrangDiem;

        public List<TrangDiem> LstTrangDiem
        {
            get { return lstTrangDiem; }
            set { lstTrangDiem = value; }
        }

        public DSTrangDiem()
        {
            LstTrangDiem = new List<TrangDiem>();
        }

        public void CapNhatGiaBan_Tang3_PhanTram()
        {
            foreach (TrangDiem x in LstTrangDiem)
            {
                x.GiaBan *= 1.03;
            }
            foreach(SanPham sp in LstSanPham)
            {
                if(sp is TrangDiem)
                {
                    sp.GiaBan *= 1.03;
                }    
            }    
           
        }

        public DSTrangDiem(List<TrangDiem> lstTrangDiem, List<SanPham> lstSanPham): base(lstSanPham)
        {
           LstTrangDiem = lstTrangDiem;
        }

        public override void XuatDSSP_Abstract()
        {
            base.XuatDSSP();
        }

        public override void NhapDSSP_Abstract()
        {
            base.NhapDSSP();
        }

        public void NhapDSTrangDiem_Xml(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);

            XmlNodeList nodeList = read.SelectNodes("/CuaHang/DSSanPham/DSTrangDiem/TrangDiem");
            foreach (XmlNode node in nodeList)
            {
                TrangDiem trd = new TrangDiem();
                trd.MaSP = node["MaSP"].InnerText;
                trd.TenSP = node["TenSP"].InnerText;
                trd.TrongLuong = float.Parse(node["TrongLuong"].InnerText);
                trd.GiaBan = double.Parse(node["GiaBan"].InnerText);
                trd.XuatXu = node["XuatXu"].InnerText;
                trd.NgaySX = DateTime.ParseExact(node["NgaySX"].InnerText, "dd/MM/yyyy", null);
                LstTrangDiem.Add(trd);
                LstSanPham.Add(trd);
            }
        }
    }
}
