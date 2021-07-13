using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDMS.DL;

namespace SDMS.BL
{
    public class userLogIn
    {
        public List<User> userAccount = new List<User>()
        {
            new User("00256","123")
        };
        public void logIn()
        {
            userSelection selection = new userSelection();
            bool successfull = false;
            Console.WriteLine("_______________");
            Console.WriteLine("STUDENT ID: ");
            string userstudentID = Console.ReadLine();
            Console.WriteLine("_______________");
            Console.WriteLine("PASSWORD: ");
            string userPassword = Console.ReadLine();

            foreach (User user in userAccount)
            {
                if (userstudentID == user.StudentID && userPassword == user.Password)
                {
                    Console.WriteLine("================================================");
                    Console.WriteLine("                 LOGIN COMPLETE                 ");
                    Console.WriteLine("================================================");

                    successfull = true;

                    selection.Selection();
                }
            }
            if (!successfull)
            {
                Console.WriteLine(".............");
            }
        }
        public void Register()
        {
            Console.WriteLine("STUDENT ID: ");
            string userStudentID = Console.ReadLine();
            Console.WriteLine("PASSWORD: ");
            string userPass = Console.ReadLine();

            userAccount.Add(new User(userStudentID, userPass));
            Console.WriteLine("YOU'VE SUCCESSFULLY REGISTERED!");

            foreach (User user in userAccount)
            {
                Console.WriteLine("STUDENT ID:{0}, PASSWORD:{1}", user.StudentID, user.Password);
            }
        }
    }
}
