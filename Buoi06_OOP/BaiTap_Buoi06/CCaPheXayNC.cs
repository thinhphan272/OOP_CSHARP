using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTap_Buoi06
{
    public class CCaPheXayNC : CCaPhe
    {
        private string congXay;

        public CCaPheXayNC()
        {
            throw new System.NotImplementedException();
        }

        public CCaPheXayNC(string congXay, string maLoai, string tenLoai, int soLuong, double donGia): base(maLoai,tenLoai, soLuong, donGia) 
        {
            this.congXay = congXay;
        }

        public override void nhapTT()
        {
            Console.WriteLine("Nhập thông tin cà phê xay nguyên chất: ");
            base.nhap();
            Console.WriteLine("Nhập công xay: ");
            congXay = Console.ReadLine();
        }
    }
}