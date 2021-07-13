using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDMS.DL;

namespace SDMS.BL
{
    public class fileManagement
    {
        public List<Files> fileInfo = new List<Files>()
        {
            new Files ("PSA", new DateTime(2021,6,26)),
        };

        public void viewFiles()
        {
            foreach (Files file in fileInfo)
            {
                Console.WriteLine("\nDOCUMENT TYPE: {0}|\nDATE: {1}|", file.fileType, file.Date);
            }
        }
        public void addNewFile()
        {
            foreach (Files file in fileInfo)
            {
                Console.WriteLine("\nDOCUMENT TYPE: {0}|\nDATE: {1}|", file.fileType, file.Date);
            }

            Console.WriteLine("ENTER A DOCUMENT TYPE: ");
            string newFile = Console.ReadLine();
            DateTime newDate = DateTime.Now;
            fileInfo.Add(new Files(newFile, newDate));
            Console.WriteLine("\nFILE NAME: {0}|\nDATE: {1}|", newFile , newDate);
            foreach (Files file in fileInfo)
            {
                Console.WriteLine("\nDOCUMENT TYPE: {0}|\nDATE: {1}|", file.fileType, file.Date);
            }
        }
        public void removeFile()
        {
            Console.WriteLine("ENTER INDEX POSITION: ");
            int indexPosition = int.Parse(Console.ReadLine());
            fileInfo.RemoveAt(indexPosition);
            foreach (Files file in fileInfo)
            {
                Console.WriteLine("\nDOCUMENT TYPE: {0}|\nDATE: {1}|", file.fileType, file.Date);
            }
        }
    }
}
