using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;

namespace BaiTap3_VeNha
{
    internal class DanhSachMonHoc
    {
        private string tenSV;
        private string maSV;
        
        private List<MonHoc> lstMonHoc = new List<MonHoc>();

        public string TenSV { get => tenSV; set => tenSV = value; }
        public string MaSV { get => maSV; set => maSV = value; }
        public List<MonHoc> LstMonHoc { get => lstMonHoc; set => lstMonHoc = value; }

        public DanhSachMonHoc() { }
        public DanhSachMonHoc(string tenSV, string maSV, List<MonHoc> lstMonHoc)
        {
            TenSV = tenSV;
            MaSV = maSV;
            LstMonHoc = lstMonHoc;
            
        }

        public void Nhap_XML(string file)
        {
            Console.InputEncoding = Encoding.UTF8;
            XmlDocument read = new XmlDocument();
            read.Load(file);

            TenSV = read.SelectSingleNode("DanhSachMonHoc/TenSV").InnerText;
            MaSV = read.SelectSingleNode("DanhSachMonHoc/MaSV").InnerText;

            XmlNodeList nodeList = read.SelectNodes("DanhSachMonHoc/MonHoc");
            foreach(XmlNode node in nodeList)
            {
                MonHoc mh;
                int l = int.Parse(node["Loai"].InnerText);

                string maMH = node["MaMH"].InnerText;
                string tenMH = node["TenMH"].InnerText;
                int soTC = int.Parse(node["SoTC"].InnerText);
                string khoaPhuTrach = node["KhoaPT"].InnerText;

                if(l == 1)
                {
                    double diemTieuLuan = double.Parse(node["DiemTieuLuan"].InnerText);
                    double diemGiuaKy = double.Parse(node["DiemGiuaKy"].InnerText);
                    double diemCuoiKy = double.Parse(node["DiemCuoiKy"].InnerText);
                    mh = new MonLyThuyet( diemTieuLuan,diemGiuaKy, diemCuoiKy,maMH, tenMH, soTC, khoaPhuTrach);
                }
                else if(l == 2) 
                {
                    double cot1 = double.Parse(node["Cot1"].InnerText);
                    double cot2 = double.Parse(node["Cot2"].InnerText);
                    double cot3 = double.Parse(node["Cot3"].InnerText);
                    double cot4 = double.Parse(node["Cot4"].InnerText);
                    mh = new MonThucHanh(cot1, cot2, cot3 , cot4, maMH, tenMH, soTC, khoaPhuTrach);
                }
                else
                {
                    double diemGVHD = double.Parse(node["DiemGVHD"].InnerText);
                    double diemGVPB = double.Parse(node["DiemGVPB"].InnerText);
                    mh = new MonDoAn(diemGVHD, diemGVPB, maMH, tenMH, soTC, khoaPhuTrach);
                }
                LstMonHoc.Add(mh);
            }    
        } 
        
        public void XuatDS()
        {
            Console.WriteLine("----------Danh Sách Môn Học----------");
            Console.WriteLine("| {0, -10} | {1, -25} | {2, -8} | {3, -30} | {4, -7} | {5, -15} |", "Mã MH", "Tên MH", "Số TC","Khoa phụ trách", "Điểm TB", "Học phí môn");
            foreach (MonHoc x in LstMonHoc)
            {
                x.Xuat();
            }    
        }    

        public double TbTichLuy()
        {
            return LstMonHoc.Average(t => t.diemTB()) * 0.4;
        }    

        public double tongTienHoc()
        {
            return LstMonHoc.Sum(t => t.hocPhiMon());
        }    

    }
}
