using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_SVTuLam
{
    internal class HD_DaiLyCap1 : HoaDon
    {

        private int tgianHopTac;
        public int TgianHopTac
        {
            get { return tgianHopTac; }
            set { tgianHopTac = value; }
        }

        public HD_DaiLyCap1() : base() { }

        public HD_DaiLyCap1(int tgianHopTac, string maKH, string tenKH, int soLuong, double giaBan) : base(maKH, tenKH, soLuong, giaBan)
        {
            TgianHopTac = tgianHopTac;
        }


        public override double tinhChietKhau()
        {
            if (TgianHopTac > 8)
                return 0.35 * GiaBan;
            else if (TgianHopTac > 3 && TgianHopTac <= 8)
            {
                int tmp = TgianHopTac - 3;
                switch(tmp)
                {
                    case 1:
                        return 0.31 * GiaBan;
                    case 2:
                        return 0.32 * GiaBan;
                    case 3:
                        return 0.33 * GiaBan;
                    case 4:
                        return 0.34 * GiaBan;
                    case 5:
                        return 0.35 * GiaBan;
                    default:
                        throw new Exception("Thời gian hợp tác không hợp lệ");
                }    

            }
            else
                return 0.3 * GiaBan;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Thời gian hợp tác: {0} năm.", TgianHopTac);
        }
    }
}
