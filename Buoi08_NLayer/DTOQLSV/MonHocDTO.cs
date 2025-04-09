using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOQLSV
{
    internal class MonHocDTO
    {
        private string maMH;
        private string tenNH;
        private int soTC;

        public MonHocDTO()
        {

        }

        public MonHocDTO(string maMH, string tenNH, int soTC)
        {
            this.maMH = maMH;
            this.tenNH = tenNH;
            this.soTC = soTC;
        }
    }
}
