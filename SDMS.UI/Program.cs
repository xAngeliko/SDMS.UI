using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDMS.BL;


namespace SDMS.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.StudentID = "0056";
            user.Password = "123123";
            int count = 0;

            while (count < 3)
            {
                if (count == 2)
                {
                    Console.WriteLine("Maximum attempts exceeded");
                    return;
                }
                else
                {
                    Console.WriteLine("\n STUDENT ID: ");
                    string studId = Console.ReadLine();
                    Console.WriteLine("\n PASSWORD: ");
                    string studPassword = Console.ReadLine();

                    if (studId.Equals(user.StudentID) && studPassword.Equals(user.Password))
                    {
                        HOME.homeUi();
                    }
                    else 
                    {
                        Console.WriteLine("INVALID ID OR PASSWORD");
                        count++;
                    }
                }
            }
        }
    }
}
