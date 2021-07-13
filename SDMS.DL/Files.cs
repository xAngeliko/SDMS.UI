using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.DL
{
    public class Files
    {
        public string fileType;
    
        private DateTime dateSubmitted;

        public Files (string filetype, DateTime date)
        {
            this.fileType = filetype;
            this.dateSubmitted = date;
        }
        public string FileType
        {
            get { return fileType; }
            set { fileType = value; }
        }        
        public DateTime Date
        {
            get { return dateSubmitted; }
            set { dateSubmitted = value; }
        }
    }
}
