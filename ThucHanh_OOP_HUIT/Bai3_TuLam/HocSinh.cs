using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_TuLam
{
    internal class HocSinh
    {
        string maHS;

        public string MaHS
        {
            get { return maHS; }
            set { maHS = value; }
        }
        string tenHS;

        public string TenHS
        {
            get { return tenHS; }
            set { tenHS = value; }
        }
        List<MonHoc> lstMonHoc  = new List<MonHoc>();

        public List<MonHoc> LstMonHoc
        {
            get
            {
                return lstMonHoc;
            }    
            set
            {
                lstMonHoc = value;
            }    
        }    

        public HocSinh() 
        {
            MaHS = null;
            TenHS = null;
            LstMonHoc = new List<MonHoc>();
        }

        public HocSinh(string maHS, string tenHS, List<MonHoc> lstMonHoc)
        {
            MaHS = maHS;
            TenHS = tenHS;
            LstMonHoc = lstMonHoc;
        }    

        public HocSinh(HocSinh hs)
        {
            MaHS = hs.MaHS;
            TenHS = hs.TenHS;
            LstMonHoc = hs.LstMonHoc;
        }

        //Tính điểm trung bình học kỳ của học sinh
        
        public double tinhDiemTB_HocKi()
        {
            return LstMonHoc.Average(t => t.diemTongKet());
        }  
        


        //Phương thức xếp loại học sinh
        public string xepLoai_HS()
        {

            if (tinhDiemTB_HocKi() >= 8.0 && LstMonHoc.All(t => t.diemTongKet() >= 6.5))
            {
                return "Giỏi";
            }
            else if (tinhDiemTB_HocKi() >= 6.5 && LstMonHoc.All(t => t.diemTongKet() >= 5.0))
            {
                return "Khá";
            }
            else if (tinhDiemTB_HocKi() >= 5.0 && LstMonHoc.All(t => t.diemTongKet() >= 3.5))
            {
                return "Trung bình";
            }
            else if (tinhDiemTB_HocKi() >= 3.5 && LstMonHoc.All(t => t.diemTongKet() >= 2.0))
            {
                return "Yếu";
            }
            else
            {
                return "Kém";
            }    
        }    

        public string xetKetQua_hocTap()
        {
            if (xepLoai_HS() == "Giỏi" || xepLoai_HS() == "Khá" || xepLoai_HS() == "Trung bình")
                return "Được lên lớp";
            else if (xepLoai_HS() == "Yếu")
                return "Thi lại";
            else
                return "Ở lại lớp";
        }    



      
        //Phương thức in danh 
        public void DanhSachMonDat(string maHS)
        {
            while(MaHS != maHS)
            {
                Console.WriteLine("Không tìm thấy học sinh có mã này. Vui lòng nhập lại!");
                maHS = Console.ReadLine();
            }
            

            Console.WriteLine("Danh sách các môn học Đạt: ");
            foreach (var MonHoc in LstMonHoc)
            {
                if (MonHoc.tinhKetQua() == "Đạt")
                {
                    MonHoc.XuatMH();
                }
            }

        }
           

        public void NhapHS()
        {
            Console.WriteLine("Nhập mã học sinh: ");
            MaHS = Console.ReadLine();
            Console.WriteLine("Nhập tên học sinh: ");
            TenHS = Console.ReadLine();
            Console.WriteLine("Nhập số lượng môn học: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập môn học thứ {0}", i + 1);
                MonHoc x = new MonHoc();
                x.NhapMH();
                LstMonHoc.Add(x);
            }    
        }    

        public void XuatHS()
        {
            Console.WriteLine("Mã học sinh: {0}\nTên học sinh: {1}", MaHS, TenHS);
            Console.WriteLine("Mã MH \t Tên MH \t Diem TX \t Diem GK \t Diem CK \t Diem TK \t Ket Qua");
            foreach (MonHoc x in LstMonHoc)
            {
                x.XuatMH();
            }    
        }    
    }
}
