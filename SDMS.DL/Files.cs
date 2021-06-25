using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.DL
{
    public class Files
    {
        private string docType;
        private DateTime dateSubmitted;

        public Files(string docType, DateTime dateSubmitted)
        {
            this.docType = docType;
            this.dateSubmitted = dateSubmitted;
        }

        public string DocType
        {
            get { return docType; }
            set { docType = value; }
        }
        public DateTime DateSubmitted
        {
            get { return dateSubmitted; }
            set { dateSubmitted = value; }
        }

    }
}
