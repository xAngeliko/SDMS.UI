using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDMS.DL;




namespace SDMS.BL
{
    public class addDoc
    {
        public static List<Files> docs = new List<Files>()
        {

        };
        public static void addFile()
        {
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("|                         ADD A DOCUMENT                            ");
            Console.WriteLine("|------------------------------------------------------------------|");

            Console.Write("ENTER A DOCUMENT TYPE: ");
            string attachDocType = Console.ReadLine();
            DateTime submissionDate = DateTime.Now;

            docs.Add(new Files(attachDocType, submissionDate));

            foreach (Files doc in docs)
            {
                Console.WriteLine("|DOC TYPE: {0} , DATE SUBMITTED : {1} |", doc.DocType, doc.DateSubmitted );
                
            }
            Console.WriteLine("|------------------------------------------------------------------|");
            Console.WriteLine("");
            Console.WriteLine("|DOC TYPE: {0} , DATE SUBMITTED : {1} | FILE ATTACHED", attachDocType, submissionDate);
            Console.WriteLine("");
            Console.WriteLine("|------------------------------------------------------------------|");
            

        }
    }
}
