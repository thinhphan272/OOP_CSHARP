using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3OOp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CThiSinh ts = new CThiSinh("Trần Văn Bảnh", "SB001", 2005, 5, 5); // gọi phương thức khởi tạo
            //ts.setHoTen("Nguyễn Văn Điện Thoại");
            //ts.setsoBD("SB001");
            //ts.setnamSinh(2005);
            //ts.setdiemLt(1.0);
            //ts.getnamSinh(10);

            //Console.WriteLine($"{ts.gethoTen()} {ts.getsoBD()} {ts.getnamSinh()} {}");
            
            ts.xuatTT();
            CThiSinh ts2 = new CThiSinh();// Khởi tạo có tham số
            ts.xuatTT();
            //CThiSinh ts3 = new CThiSinh(ts); // Khởi tạo sao chép 
            ts2.xuatTT();
            ts.setsoBD("SB002");
            ts.xuatTT();
            ts2.xuatTT();
            ts2.sethoVaTen("Thẳng lưng");
            ts.xuatTT();
            ts2.xuatTT();

            Console.ReadKey();  
        }

        
    }
}
