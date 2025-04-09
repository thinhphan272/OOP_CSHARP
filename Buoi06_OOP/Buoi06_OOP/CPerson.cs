using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi06_OOP
{
    public abstract class CPerson
    {
        private string hoTen;
        private string gioiTinh;
        private DateTime ngaySinh;

        public CPerson()
        {
            throw new System.NotImplementedException();
        }

        public CPerson(string hoTen, string gioiTinh, DateTime ngaySinh)
        {
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh   = ngaySinh;
        }
        
            

        public virtual void nhap()
        {
            Console.WriteLine("Nhập họ tên: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhập giới tính: ");
            gioiTinh= Console.ReadLine();
            Console.WriteLine("Nhập ngày sinh: ");
            ngaySinh = DateTime.Parse(Console.ReadLine());

        }

        public abstract void nhapTT();

        public override string ToString() 
        {
            return hoTen + "_" + gioiTinh + "_" + ngaySinh;
        }
    }
}