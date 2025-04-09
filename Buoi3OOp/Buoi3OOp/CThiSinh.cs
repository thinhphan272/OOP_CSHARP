using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3OOp
{
    internal class CThiSinh
    {
        private String hoVaTen;
        private String soBD;
        private int namSinh;
        private double diemLt;
        private double diemTh;
        //properties

        public String HoVaTen
        {
            get { return hoVaTen; }
            set {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                    throw new Exception("Họ và tên không được để trống");
                else
                    hoVaTen = value;
            }
            
        }

        public double DiemLT
        {
            get
            {
                return diemLt;
            }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Điểm không được bé hơn 0");
                }    
                else
                    diemLt = value;
            }
        }
        //phuong thuc giao tiep 

        public String gethoVaTen()
        {
            return hoVaTen;
        }
        public String getsoBD()
        { return soBD; }
        public int getnamSinh() { return namSinh; }
        public double getDiemLt() {  return diemLt; }
        public double getDiemTh() {  return diemTh; }

        public void sethoVaTen(String hoVaTen)
        {
            this.hoVaTen = hoVaTen;
        }
        public void setsoBD(String soBD)
        {
            this.soBD = soBD;
        }
        public void setnamSinh(int namSinh)
        {
            this.namSinh = namSinh;
        }
        public void setdiemLt(double  diemLt)
        {
            this.diemLt = diemLt;

        }
        public void setdiemTh(double diemTh)
        {
            this.diemTh = diemTh;
        }


        //xet ket qua
        public String xetKetQua()
        {
            double diemtong = diemLt + diemTh;
            if (diemtong > 10 && diemLt >= 2 && diemTh >= 2)
                return "Đậu";
            return "Chưa đậu";
        }

        //constructor

        public CThiSinh()
        {
            hoVaTen = "Nguyễn Văn A";
            soBD = "SB001";
            namSinh = 2006;
            diemLt = 5;
            diemTh = 3;
        }

        public CThiSinh(String hoVaTen, String soBD, int namSinh, double diemLt, double diemTh)
        {
            this.hoVaTen = hoVaTen;
            this.soBD = soBD;
            this.namSinh = namSinh;
            this.diemLt = diemLt;
            this.diemTh = diemTh;
        }

        //Khoi tao sao chep
        public CThiSinh(CThiSinh obj)
        {
            this.hoVaTen=obj.hoVaTen;
            this.soBD=obj.soBD;
            this.namSinh=obj.namSinh;
            this.diemLt=obj.diemLt; ;
            this.diemTh=obj.diemTh;
        }
        //hien thi thong tin 

        public void xuatTT()
        {
            Console.WriteLine();
        }
    }
}
