using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai4_BTVN
{
    internal class CuaHangXangDau
    {
        List<HoaDon> lstHoaDon = new List<HoaDon>();
        List<MatHang> lstMatHang = new List<MatHang>();
        public List<HoaDon> LstHoaDon
        {
            get { return lstHoaDon; }
            set { lstHoaDon = value; }
        }

        public List<MatHang> LstMatHang 
        { get => lstMatHang; set => lstMatHang = value; }

        public CuaHangXangDau() { }

        public CuaHangXangDau(List<HoaDon> lstHoaDon)
        {
            LstHoaDon = lstHoaDon;
            
        }

        public void Nhap_Xml(string file)
        {
            Console.InputEncoding = Encoding.UTF8;
            XmlDocument read = new XmlDocument();
            read.Load(file);

            XmlNodeList nodeList = read.SelectNodes("/CuaHang/HoaDon");
            foreach (XmlNode node in nodeList) 
            {
                HoaDon hd;
                int l = int.Parse(node["Loai"].InnerText);
                string maSo = node["MaSo"].InnerText;
                string hoTenKhach = node["HoTenKhach"].InnerText;
                string ngayLap = node["NgayLap"].InnerText;
                int soLuong = int.Parse(node["SoLuong"].InnerText);
                

                XmlNode matHangNode = node.SelectSingleNode("MatHang");
                MatHang matHang = new MatHang();
                matHang.MaHang = matHangNode["MaHang"].InnerText;
                matHang.TenHang = matHangNode["TenHang"].InnerText;
                matHang.GiaBan = double.Parse(matHangNode["GiaBan"].InnerText);

                if (l == 1)
                {
                    hd = new HD_VangLai(maSo, hoTenKhach, ngayLap, matHang, soLuong);
                }
                else if (l == 2)
                {
                    hd = new HD_VIP(maSo, hoTenKhach, ngayLap, matHang, soLuong);
                }
                else
                {
                    hd = new HD_ThanThiet(maSo, hoTenKhach, ngayLap, matHang, soLuong);
                }
                LstHoaDon.Add(hd);

                
  
            }


        }

        public void XuatDS()
        {
            foreach(HoaDon x in LstHoaDon)
            {
                x.Xuat();
            }    
        }

        public double tinhTongHD()
        {
            return LstHoaDon.Sum(t => t.tinhTriGia());
        }

        public List<HoaDon> xuatHoaDon_Max()
        {
            double max = LstHoaDon.Max(t => t.tinhTriGia());
            return LstHoaDon.Where(t => t.tinhTriGia() == max).ToList();
        }

        public int demHoaDon_KhachVIP()
        {

            return LstHoaDon.OfType<HD_VIP>().Count();
        }
        public int demHoaDon_KhachThanThiet()
        {
            return LstHoaDon.OfType<HD_ThanThiet>().Count();
        }

        public List<HoaDon> sapXep()
        {
            return LstHoaDon.OrderBy(t => t.tinhTriGia()).ThenByDescending(t => t.MaSo).ToList();
        }

    }
}
