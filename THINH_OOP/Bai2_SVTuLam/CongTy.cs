using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using System.Xml;

namespace Bai2_SVTuLam
{
    internal class CongTy
    {
        private string tenCTY;
        private string diaChi;
        private string dienThoai;
        private List<HoaDon> lstHoaDon = new List<HoaDon>();

        public string TenCTY { get => tenCTY; set => tenCTY = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public List<HoaDon> LstHoaDon { get => lstHoaDon; set => lstHoaDon = value; }

        public CongTy()
        {
            
        }   
        
        public CongTy(string tenCTY, string diaChi, string dienThoai, List<HoaDon> lstHoaDon)
        {
            TenCTY = tenCTY;
            DiaChi = diaChi;
            DienThoai = dienThoai;
            LstHoaDon = lstHoaDon;
        }    

        public void Nhap_XML(string file)
        {
            Console.InputEncoding = Encoding.UTF8;
            XmlDocument read = new XmlDocument();

            read.Load(file);

            TenCTY = read.SelectSingleNode("/CongTy/TenCTY").InnerText;
            DiaChi = read.SelectSingleNode("/CongTy/DiaChi").InnerText;
            DienThoai = read.SelectSingleNode("/CongTy/DienThoai").InnerText;

            XmlNodeList nodeList = read.SelectNodes("/CongTy/HoaDon");
            foreach (XmlNode node in nodeList) 
            {
                HoaDon hd;
                int l = int.Parse(node["Loai"].InnerText);

                string maKH = node["MaKH"].InnerText;
                string tenKH = node["TenKH"].InnerText;
                int soLuong = int.Parse(node["SoLuong"].InnerText);
                double giaBan = double.Parse(node["GiaBan"].InnerText);

                if(l == 1)
                {
                    double khoangCachGH = double.Parse(node["KhoangCachGH"].InnerText);
                    hd = new HD_KhachHangCaNhan(khoangCachGH, maKH, tenKH, soLuong, giaBan);

                }    
                else if(l == 2) 
                {
                    int tgianHopTac = int.Parse(node["TGHopTac"].InnerText);
                    hd = new HD_DaiLyCap1(tgianHopTac, maKH, tenKH, soLuong, giaBan);
                }
                else
                {
                    int soLuongNV = int.Parse(node["SoLuongNV"].InnerText);
                    hd = new HD_KHCongTy(soLuongNV, maKH, tenKH, soLuong, giaBan);
                }    
                LstHoaDon.Add(hd);
            }
        }    

        public void XuatDS()
        {
            Console.WriteLine("Tên công ty phân phối: {0}", TenCTY);
            Console.WriteLine("Địa chỉ: {0}", DiaChi);
            Console.WriteLine("Liên hệ: {0}", DienThoai);
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            foreach (HoaDon hd in LstHoaDon)
            {
                hd.Xuat();
            }
        }


        public double tongThanhTien()
        {
            return LstHoaDon.Sum(t => t.tinhThanhTien());
        }

        public List<HoaDon> soLuongMuaNhieuNhat()
        {
            
            double max = LstHoaDon.Max(t => t.SoLuong);
            return LstHoaDon.Where(t => t.SoLuong ==  max).ToList();
        }    

        public double tongChietKhau_KHCongTy()
        {
            
            return LstHoaDon.OfType<HD_KHCongTy>().Sum(t => t.tinhChietKhau());
        }

        public void XuatDaiLyCap1()
        {
            foreach(HoaDon x in LstHoaDon)
            {
                if(x is HD_DaiLyCap1)
                    x.Xuat();
            }   
        }    

        public List<HoaDon> SapXepDSTangDan()
        {
            return LstHoaDon.OrderBy(t => t.SoLuong).ThenByDescending(t => t.tinhThanhTien()).ToList();
        }   
  
        public List<HoaDon> timHoaDonTheoMaKH(string maKH)
        {
            return LstHoaDon.Where(t => t.MaKH == maKH).ToList();
        } 
    }
}
