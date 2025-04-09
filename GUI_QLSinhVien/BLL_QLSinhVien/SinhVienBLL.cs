using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL_QLSinhVien;
using DTO_QLSinhVien;

namespace BLL_QLSinhVien
{
    public class SinhVienBLL
    {
        #region Attributes

        SinhVienDAL studentDAL = new SinhVienDAL();


        #endregion

        #region Methods

        public SinhVienBLL()
        {

        }

        public List<SinhVienDTO> getStudentList()
        {
            return studentDAL.readFile("../../../Data/StudentList.xml");
        }


        #endregion
    }
}
