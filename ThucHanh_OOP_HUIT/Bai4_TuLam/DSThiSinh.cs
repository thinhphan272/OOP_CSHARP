using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_TuLam
{
    internal class DSThiSinh
    {
        List<ThiSinh> lstThiSinh = new List<ThiSinh>();

        public List<ThiSinh> LstThiSinh
        {
            get
            {
                return lstThiSinh;

            }   
            set
            {
                lstThiSinh = value;
            }    
        }    

        public DSThiSinh() 
        {
            LstThiSinh = new List<ThiSinh>();
        }

        public DSThiSinh(List<ThiSinh> lstThiSinh)
        {
            LstThiSinh = lstThiSinh;
        }    

        public DSThiSinh(DSThiSinh ds)
        {
            LstThiSinh = ds.LstThiSinh;
            
        }

        public DSThiSinh SortDecreasing()
        {
            DSThiSinh lst = new DSThiSinh();
            lst.LstThiSinh = LstThiSinh.OrderByDescending(t => t.tinhDiemTongKet()).ToList();
            return lst;
        }    

        public void SeachTS(string maTS)
        {
            ThiSinh x = LstThiSinh.FirstOrDefault(t => t.MaTS == maTS);

            while (x == null)
            {
                Console.WriteLine("Không tìm thấy thí sinh vui lòng nhập lại!");
                maTS = Console.ReadLine();
                x = LstThiSinh.FirstOrDefault(t => t.MaTS == maTS);
            }

            Console.WriteLine("{0} \t {1} \t\t {2} \t\t {3} \t\t {4} \t\t {5} \t\t {6}", x.MaTS, x.HoTen, x.GioiTinh, x.DiemLT, x.DiemTH, Math.Round(x.tinhDiemTongKet(), 2), x.xetTuyen());

        }    


        public int tongThiSinh_Rot()
        {
            int sum = 0;
            foreach (var ThiSinh in LstThiSinh)
            {
                if (ThiSinh.xetTuyen() == "Rớt")
                {
                    sum++;
                }
            }
            return sum;
        }

        public int tongThiSinh_Dau()
        {
            int sum = 0;
            foreach (var ThiSinh in LstThiSinh)
            {
                if(ThiSinh.xetTuyen() == "Đậu")
                {
                    sum++;
                }    
            }    
            return sum;
        }    

        public void ThiSinh_Dau()
        {

            Console.WriteLine("\nThí sinh có kết quả đậu");
            foreach (var ThiSinh in LstThiSinh)
            {
                if(ThiSinh.xetTuyen() == "Đậu")
                {
                    ThiSinh.XuatTS();
                }
                
            }    
        }    

        public void NhapDS()
        {
            
            Console.WriteLine("Nhập số lượng thí sinh");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++) 
            {
                Console.WriteLine("Nhập thí sinh thứ {0}", i + 1);
                ThiSinh x = new ThiSinh();
                x.NhapTS();
                LstThiSinh.Add(x);
            }
        }    

        public void XuatDS()
        {
            Console.WriteLine("Danh sách các thí sinh:");
            Console.WriteLine("Mã TS  | Tên TS               | Giới Tính | Điểm LT | Điểm TH | Điểm TK | KQ Xét Tuyển |");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            foreach (ThiSinh x in LstThiSinh)
            {
                x.XuatTS();
            }
            Console.WriteLine("---------------------------------------------------------------------------------------");
        }    
    }
}
