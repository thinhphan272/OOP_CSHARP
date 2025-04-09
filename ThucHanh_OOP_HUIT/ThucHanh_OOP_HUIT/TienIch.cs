using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh_OOP_HUIT
{
    public static class TienIch
    {
        public static int TimUCLN(int a, int b)
        {
            if (a == 0 || b == 0)
                return a + b;
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }
    }
}
