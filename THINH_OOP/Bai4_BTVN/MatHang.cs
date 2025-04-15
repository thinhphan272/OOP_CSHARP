using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_BTVN
{
    public class MatHang
    {
        private string maHang;
        private string tenHang;
        private double giaBan;

        public string MaHang
        {
            get { return maHang; }
            set 
            {
               
                maHang = value; 
            }
        }

        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }

        public double GiaBan
        {
            get { return giaBan;}
            set { giaBan = value; }
        }

        public MatHang() 
        {
            MaHang = "None";
            TenHang = "None";
            giaBan = 0;
        }
        public MatHang(string maHang, string tenHang, double giaBan)
        {
            MaHang = maHang;
            TenHang = tenHang;
            GiaBan = giaBan;
            
        }


    }
}
