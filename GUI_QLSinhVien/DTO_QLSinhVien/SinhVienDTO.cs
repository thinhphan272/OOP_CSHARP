using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSinhVien
{
    public class SinhVienDTO
    {
        #region Atrributes

        private string _studentID;

        public String StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }

        private String _firstName;

        public String FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private String _lastName;

        public String LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private String _phone;

        public String Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private String _email;

        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }


        private double _averageScore;

        public double AverageScore
        {
            get { return _averageScore; }
            set { _averageScore = value; }
        }

        #endregion

        #region Methods

        public SinhVienDTO()
        {
            this.StudentID = "";
            this.LastName = "";
            this.FirstName = "";
            this.Phone = "";
            this.Email = "";
            this.AverageScore = 0;

        }

        public SinhVienDTO(string id, string lname, string fname, string phone, string email, double avgScore)
        {
            this.StudentID = id;
            this.LastName = lname;
            this.FirstName = fname;
            this.Phone = phone;
            this.Email = email; 
            this.AverageScore = avgScore;
        }

        //=========Input/Output

        public string toString()
        {
            string kq = StudentID + "\t\t" + LastName + "\t" + FirstName;

            if (LastName.Length <= 15)
                kq += "\t\t" + Phone;
            else if (LastName.Length <= 22)
                kq += "\t" + Phone;
            else
                kq += Phone;

            kq += "\t" + Email;

            if (Email.Length <= 15)
                kq += "\t\t" + AverageScore;
            else if (Email.Length <= 22)
                kq += "\t" + AverageScore;

            return kq;
        }

        #endregion


    }




}
