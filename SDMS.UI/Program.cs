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
            userLogIn user = new userLogIn();
            Console.WriteLine("________________________________________________");
            Console.WriteLine("          PRESS --->>(1)<<---LOG IN             ");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("          PRESS --->>(2)<<--REGISTER            ");
            Console.WriteLine("================================================");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput.Equals(1))
            {
                user.logIn();
            }
            else if (userInput.Equals(2))
            {
                user.Register();
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
            }
        }
    }
}
