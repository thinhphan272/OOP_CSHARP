using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Xml;


namespace DoAn_OOP_QLMyPham
{
    public abstract class DSSanPham
    {
        List<SanPham> lstSanPham = new List<SanPham>();

        public List<SanPham> LstSanPham
        {
            get { return lstSanPham; }
            set { lstSanPham = value; }
        }
        public DSSanPham()
        {
            LstSanPham = new List<SanPham>();
        }

        public DSSanPham(List<SanPham> lstSanPham)
        {
            LstSanPham = lstSanPham;
        }

        public DSSanPham(DSSanPham lst)
        {
            LstSanPham = lst.LstSanPham;
        }





        public DanhSachSanPham Loc_DSSP_GiaBan_Hon300000()
        {
            DanhSachSanPham ds = new DanhSachSanPham();
            ds.LstSanPham = LstSanPham.Where(t => t.GiaBan > 300000).ToList();
            return ds;
        }

        public DanhSachSanPham Loc_Theo_XuatXu(string xuatXu)
        {
            DanhSachSanPham ds = new DanhSachSanPham();
            ds.LstSanPham = LstSanPham.Where(t => t.XuatXu == xuatXu).ToList();
            return ds;
        }


        public abstract void XuatDSSP_Abstract();
        public abstract void NhapDSSP_Abstract();
        
        

        public void XuatDSSP()
        {
            Console.WriteLine("\n----------------------------DANH SÁCH SẢN PHẨM TẠI CỬA HÀNG----------------------------");
            Console.WriteLine("| {0, -7} | {1, -23} | {2, -9} | {3, -10} | {4, -7} | {5, -10} |",
    "Mã SP", "Tên Sản Phẩm", "Trọng Lượng", "Giá Bán", "Xuất Xứ", "Ngày SX");
            foreach (SanPham x in LstSanPham) 
            {
                x.XuatSP();
            }
            Console.WriteLine("\n---------------------------------------------------------------------------------------");
        }

        public void NhapDSSP()
        {
            Console.WriteLine("Nhập số lượng sản phẩm muốn thêm: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập sản phẩm thứ {0}:\n1 - KEM CHỐNG NẮNG\n2 - TẨY TRANG\n3 - SỬA RỬA MẶT\n4 - TRANG ĐIỂM\n5 - CHĂM SÓC DA", i + 1);
                int loaiSP = int.Parse(Console.ReadLine());

                SanPham sp = null;
                switch(loaiSP)
                {
                    case 1:
                        sp = new KemChongNang();
                        break;
                    case 2:
                        sp = new TayTrang();
                        break;
                    case 3:
                        sp = new SuaRuaMat();
                        break;
                    case 4:
                        sp = new TrangDiem();
                        break;
                    case 5:
                        sp = new ChamSocDa();
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại!!");
                        i--;
                        continue;
                }    

                if(sp != null)
                {
                    sp.NhapSP();
                    LstSanPham.Add(sp);
                }     
            }
        }

        public void NhapDSSP_Xml(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);

            XmlNodeList nodelist = read.SelectNodes("/CuaHang/DSSanPham/*/*");

            
            foreach(XmlNode node in nodelist)
            {
                SanPham sp = null;
                switch (node.Name)
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

                if (sp != null)
                {
                    sp.MaSP = node["MaSP"].InnerText;
                    sp.TenSP = node["TenSP"].InnerText;
                    sp.TrongLuong = float.Parse(node["TrongLuong"].InnerText);
                    sp.GiaBan = double.Parse(node["GiaBan"].InnerText);
                    sp.XuatXu = node["XuatXu"].InnerText;
                    sp.NgaySX = DateTime.ParseExact(node["NgaySX"].InnerText, "dd/MM/yyyy", null);
                    LstSanPham.Add(sp);
                }    

            }    
        }

        //Lọc danh sách sản phẩm có ngày sản xuất hơn 3 tháng

        public DanhSachSanPham Loc_DSSP_NgaySXHon3Thang()
        {
            DanhSachSanPham ds = new DanhSachSanPham();
            DateTime threeMonthsAgo = DateTime.Now.AddMonths(-3);

            ds.LstSanPham = LstSanPham.Where(sp => sp.NgaySX < threeMonthsAgo).ToList();

            return ds;
        }

        public void Xuat_SP_TrangDiem()
        {
            var dsTrangDiem = LstSanPham.Where(sp => sp is TrangDiem);
            foreach (var sp in dsTrangDiem)
            {
                sp.XuatSP();
            }
        }

    }
}