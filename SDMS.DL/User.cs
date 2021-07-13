using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.DL
{
    public class User
    {
        private string studentID { get; set; }
        private string password { get; set; }

        public User(string studentID, string password)
        {
            this.studentID = studentID;
            this.password = password;
        }

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
