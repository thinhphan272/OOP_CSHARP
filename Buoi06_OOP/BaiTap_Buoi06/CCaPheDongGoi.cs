using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTap_Buoi06
{
    public class CCaPheDongGoi : CCaPhe
    {
        private string loaiBaoBi;

        public CCaPheDongGoi()
        {
            
        }

        public CCaPheDongGoi(string loaiBaoBi, string maLoai, string tenLoai, int soLuong, double donGia):base(maLoai,tenLoai,soLuong,donGia)
        {
            this.loaiBaoBi = loaiBaoBi;
        }

        public override void nhapTT()
        {
            Console.WriteLine("Nhập thông tin cà phê đóng gói: ");

            base.nhap();
            Console.WriteLine("Nhập loại bao bì: ");
            loaiBaoBi = Console.ReadLine();
        }

  

        public override string ToString()
        {
            return base.ToString() + " " + loaiBaoBi;
        }
    }
}