using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.BL
{
    public class userSelection
    {
        public void Selection()
        {
            fileManagement fileServices = new fileManagement();

        START:
            Console.WriteLine("================================================");
            Console.WriteLine("        PRESS --->>(1)<<--- VIEW FILES          ");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("        PRESS --->>(2)<<--- ADD FILE/S          ");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("        PRESS --->>(3)<<--- REMOVE FILES        ");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("        PRESS --->>(4)<<--- EXIT                ");
            Console.WriteLine("================================================");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    fileServices.viewFiles();
                    goto START;
                case 2:
                    fileServices.addNewFile();
                    goto START;
                case 3:
                    fileServices.removeFile();
                    goto START;

                default:
                    break;
            }
        }
    }
}
