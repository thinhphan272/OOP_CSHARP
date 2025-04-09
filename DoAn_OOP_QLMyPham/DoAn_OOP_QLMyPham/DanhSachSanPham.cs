using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoAn_OOP_QLMyPham
{
    public class DanhSachSanPham : DSSanPham
    {
        
        
        public DanhSachSanPham() : base() { }

        public override void XuatDSSP_Abstract()
        {
            base.XuatDSSP();
        }

        public override void NhapDSSP_Abstract()
        {
            base.NhapDSSP();
        }

    }
}