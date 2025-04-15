using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_Interface
{
    public class TaiKhoan 
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string SoDienThoai { get; set; }
        public string TrangThai { get; set; } // online, offline

        public TaiKhoan(string username, string password, string soDienThoai)
        {
            Username = username;
            Password = password;
            SoDienThoai = soDienThoai;
            TrangThai = "offline";
        }

        public void DangNhap()
        {
            TrangThai = "online";
        }

        public void DangXuat()
        {
            TrangThai = "offline";
        }

        public int LayDiaChiTuGoogleMap()
        {
            Random rand = new Random();
            return rand.Next(1000);
        }
    }
}
