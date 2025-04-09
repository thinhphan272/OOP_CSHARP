using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using System.Xml;

using DTO_QLSinhVien;

namespace DAL_QLSinhVien
{
    public class SinhVienDAL
    {
        #region Attributes

        List<SinhVienDTO> _lstStudent = new List<SinhVienDTO> ();
        #endregion


        #region Methods

        public SinhVienDAL() { }

        internal List<SinhVienDTO> lstStudent
        {
            get { return _lstStudent; }
            set { _lstStudent = value; }
        }

        public List<SinhVienDTO> readFile(string filename)
        {
            Console.InputEncoding = Encoding.UTF8;

            try
            {
                XmlDocument read = new XmlDocument();
                read.Load(filename);
                XmlNodeList nodeList = read.SelectNodes("StudentList/Student");
                foreach (XmlNode node in nodeList) 
                {
                    SinhVienDTO st = new SinhVienDTO();
                    st.StudentID = node["StudentID"].InnerText;
                    st.FirstName = node["FirstName"].InnerText;
                    st.LastName = node["LastName"].InnerText;
                    st.Phone = node["Phone"].InnerText;
                    st.Email = node["Email"].InnerText;
                    st.AverageScore = double.Parse(node["AverageScore"].InnerText);
                    lstStudent.Add(st);

                }
                return lstStudent;
            }
            catch (Exception e) 
            {
                return null;
            }
        }

        #endregion
    }
}
