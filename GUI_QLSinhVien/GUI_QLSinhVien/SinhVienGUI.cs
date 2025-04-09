using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO_QLSinhVien;
using BLL_QLSinhVien;

namespace GUI_QLSinhVien
{
    public class SinhVienGUI
    {
        #region Attributes

        SinhVienBLL studentBLL = new SinhVienBLL();


        #endregion


        #region Methods

        public void showStudentList()
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                Console.WriteLine("\t\t\t\t\t\tSTUDENT LIST");
                string kq = "StudentID\tFull name\t\t\tPhone\t\tE-mail\t\t\tAverage Score";
                Console.WriteLine(kq);

                List<SinhVienDTO> lstStudent = new List<SinhVienDTO>();
                lstStudent = studentBLL.getStudentList();

                foreach (SinhVienDTO st in lstStudent)
                {
                    Console.WriteLine(st.toString());
                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion



    }
}
