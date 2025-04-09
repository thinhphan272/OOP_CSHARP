using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace DoAn_OOP_QLMyPham
{
    public class DSKhachHang
    {
        private List<KhachHang> lstKhachHang = new List<KhachHang>();

        public List<KhachHang> LstKhachHang
        { 
            get { return  lstKhachHang; }
            set { lstKhachHang = value;}

        }

        public DSKhachHang() { }
        public DSKhachHang(List<KhachHang> lstKhachHang) 
        {
            LstKhachHang = lstKhachHang;
        }

        public DSKhachHang(DSKhachHang dskh) 
        {
            LstKhachHang = dskh.LstKhachHang;
        }

        public void NhapDSKH()
        {
            Console.WriteLine("Nhập số lượng khách hàng muốn thêm: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++) 
            {
                Console.WriteLine("--Nhập thông tin khách hàng thứ {0}--", i+1);
                KhachHang x = new KhachHang();
                x.NhapKH();
                LstKhachHang.Add(x);
            }
        }

        public void XuatDSKH()
        {
            Console.WriteLine("\n-------------------------------DANH SÁCH KHÁCH HÀNG------------------------------------");
            if(LstKhachHang.Count == 0)
            {
                Console.WriteLine("Không có khách hàng!");
            }
            else
            {
                foreach (KhachHang x in LstKhachHang)
                {
                    
                    x.XuatKH();
                }
            } 
            Console.WriteLine("\n---------------------------------------------------------------------------------------");

        }

        public DSKhachHang XuatDS_Theo_TenKH(string tenKH)
        {
            DSKhachHang x = new DSKhachHang();
            x.LstKhachHang = LstKhachHang.Where(t => t.TenKH == tenKH).ToList();
            return x;
        }

        public void NhapDSKH_Xml(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);

            LstKhachHang = new List<KhachHang>();

            

            XmlNodeList nodeList_KhachHang = read.SelectNodes("/CuaHang/DSKhachHang/KhachHang");

            foreach(XmlNode node_KhachHang in nodeList_KhachHang)
            {
                
                KhachHang kh = new KhachHang();
                kh.MaKH = node_KhachHang["MaKH"].InnerText;
                kh.TenKH = node_KhachHang["TenKH"].InnerText;
                kh.SoDienThoai = long.Parse(node_KhachHang["SDT"].InnerText);

                kh.LstSanPhamDaMua = new List<SanPham>();
                XmlNodeList nodeList_SanPham = node_KhachHang.SelectNodes("DSSanPhamDaMua/*");

                foreach(XmlNode node_SanPhamDaMua in nodeList_SanPham)
                {
                    SanPham sp = null;
                    switch(node_SanPhamDaMua.Name)
                    {
                        case "KemChongNang":
                            sp = new KemChongNang();
                            break;
                        case "TayTrang":
                            sp = new TayTrang();
                            break;
                        case "SuaRuaMat":
                            sp = new SuaRuaMat();
                            break;
                        case "TrangDiem":
                            sp = new TrangDiem();
                            break;
                        case "ChamSocDa":
                            sp = new ChamSocDa(); 
                            break;
                    }    

                    if(sp != null)
                    {
                        sp.MaSP = node_SanPhamDaMua["MaSP"].InnerText;
                        sp.TenSP = node_SanPhamDaMua["TenSP"].InnerText;
                        sp.TrongLuong = float.Parse(node_SanPhamDaMua["TrongLuong"].InnerText);
                        sp.GiaBan = double.Parse(node_SanPhamDaMua["GiaBan"].InnerText);
                        sp.XuatXu = node_SanPhamDaMua["XuatXu"].InnerText;
                        sp.NgaySX = DateTime.ParseExact(node_SanPhamDaMua["NgaySX"].InnerText, "dd/MM/yyyy", null);
                        
                        kh.LstSanPhamDaMua.Add(sp);
                        
                    }    
                }

                LstKhachHang.Add(kh);
            }
        }

        public void XuatDSKH_MuaNhieuHon3SP()
        {
            Console.WriteLine("\n-------------------- DANH SÁCH KHÁCH HÀNG MUA NHIỀU HƠN 3 SẢN PHẨM --------------------");

            var khachHangMuaNhieuHon3 = LstKhachHang.Where(kh => kh.LstSanPhamDaMua.Count > 3).ToList();

            if (khachHangMuaNhieuHon3.Count == 0)
            {
                Console.WriteLine("Không có khách hàng nào mua hơn 3 sản phẩm.");
            }
            else
            {
                foreach (KhachHang kh in khachHangMuaNhieuHon3)
                {
                    kh.XuatKH();
                }
            }

            Console.WriteLine("\n---------------------------------------------------------------------------------------");
        }
    }
}