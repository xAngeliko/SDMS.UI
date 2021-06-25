using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.UI
{
    class HOME
    {
        public static void homeUi()
        {
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine(" PRESS 'A' - TO SUBMIT A FILE ");
            Console.WriteLine(" PRESS 'B' - TO GO TO 'MY FILES' ");
            Console.WriteLine(" PRESS 'C' - TO LOG OUT  ");
            char option = Convert.ToChar(Console.ReadLine());
            option = char.ToUpper(option);

            switch (option)
            {
                case 'A':

                    break;
                case 'B':

                    break;

                case 'C':
                    SDMS.UI.EXIT.logOut();
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
        
    }
    class EXIT
    {
        public static void logOut()
        {
            Console.WriteLine("---------------------------Logging out------------------------------");
            Environment.Exit(0);
        }
    }
  
}
