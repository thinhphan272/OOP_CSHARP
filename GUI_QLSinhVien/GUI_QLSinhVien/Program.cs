using BLL_QLSinhVien;
using DTO_QLSinhVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GUI_QLSinhVien
{
    internal class Program
    {
        public static void testStudentList()
        {
            SinhVienGUI studentGUI = new SinhVienGUI();
            studentGUI.showStudentList();

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            testStudentList();
        }
    }
}
