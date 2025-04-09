using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _44_PhanSiThinh_2001230933
{
    class HoaDon
    {
        string tenKhachHang;

        public string TenKhachHang
        {
            get { return tenKhachHang; }
            set { tenKhachHang = value; }
        }
        string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        string ngayMuaHang;

        public string NgayMuaHang
        {
            get { return ngayMuaHang; }
            set { ngayMuaHang = value; }
        }

        List<ChiTietSanPham> lstChiTietSP = new List<ChiTietSanPham>();

        internal List<ChiTietSanPham> LstChiTietSP
        {
            get { return lstChiTietSP; }
            set { lstChiTietSP = value; }
        }

        public HoaDon()
        {
            
        }

        public HoaDon(string tenKhachHang, string diaChi, string ngayMuaHang, List<ChiTietSanPham> lstChiTietSP)
        {
            TenKhachHang = tenKhachHang;
            DiaChi = diaChi;
            NgayMuaHang = ngayMuaHang;
            LstChiTietSP = lstChiTietSP;
        }


        public void DocDSHoaDon(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);    

            TenKhachHang = read.SelectSingleNode("/HoaDon/TenKhachHang").InnerText;
            DiaChi = read.SelectSingleNode("/HoaDon/DiaChi").InnerText;
            NgayMuaHang = read.SelectSingleNode("/HoaDon/NgayMua").InnerText;

            XmlNodeList nodelist = read.SelectNodes("/HoaDon/DSCTSP/Sanpham");

            foreach (XmlNode node in nodelist)
            {
                ChiTietSanPham sp = new ChiTietSanPham();
                sp.MaSP = node["MaSP"].InnerText;
                sp.TenSP = node["TenSP"].InnerText;
                sp.DonGia = float.Parse(node["DonGia"].InnerText);
                sp.SoLuong = int.Parse(node["SoLuong"].InnerText);
                sp.LoaiSP = node["Loai"].InnerText;
                LstChiTietSP.Add(sp);
            }
        }

        public void XuatDSHoaDon()
        {
            Console.WriteLine("Ten khach hang: {0}", TenKhachHang);
            Console.WriteLine("Dia chi: {0}", DiaChi);
            Console.WriteLine("Ngay mua: {0}", NgayMuaHang);
            foreach(ChiTietSanPham sp in LstChiTietSP)
            {
                sp.XuatSP();
            }
        }

        public double TongHoaDon()
        {
            return LstChiTietSP.Sum(t => t.thanhTienChiTiet());
        }

        public ChiTietSanPham sp_tienCT_Max()
        {
            double max = LstChiTietSP.Max(t => t.thanhTienChiTiet());
            return LstChiTietSP.FirstOrDefault(x => x.thanhTienChiTiet() == max);
        }

        public HoaDon Loc_Sp_Tra()
        {
            HoaDon hd = new HoaDon();
            hd.LstChiTietSP = LstChiTietSP.Where(t => t.LoaiSP == "tra").ToList();
            return hd;
        }


        public void xuatSP_theoMa(string maSP)
        {           
            
            foreach (var ChiTietSanPham in LstChiTietSP)
            {
                if (ChiTietSanPham.MaSP == maSP)
                {
                    ChiTietSanPham.XuatSP();
                }
            }
        }

        public HoaDon sort_Tang_Dan()
        {
            HoaDon hd = new HoaDon();
            hd.LstChiTietSP = LstChiTietSP.OrderBy(t => t.SoLuong).ToList();
            return hd;
        }
        
    }
}
