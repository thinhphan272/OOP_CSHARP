using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi3
{
    internal class hinhtron
    {
        private double canhA;
        private double canhB;
        private double canhC;
        public double CanhA
        {


            get { return canhA; }
            set
            {
                if (value < 0)
                    throw new Exception("Cạnh phải lớn hơn 0");
                else
                    canhA = value;
            }


        }

        public double CanhB
        {


            get { return CanhB; }
            set
            {
                if (value < 0)
                    throw new Exception("Cạnh phải lớn hơn 0");
                else
                    CanhB = value;
            }


        }

        public double CanhC
        {


            get { return canhC; }
            set
            {
                if (value < 0)
                    throw new Exception("Cạnh phải lớn hơn 0");
                else
                    canhC = value;
            }
        }
        public double tinhChuVi()
        {
            return canhA + canhB + canhC;
        }

        public double dienTich()
        {
            double P = (canhA + canhB + canhC) / 2;
            return P;
        }
    }
}

