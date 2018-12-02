using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EEP_Models.Models
{
    public class Inter
    {
        public string IRollNo { get; set; }
        public int IMarks { get; set; }
        public double IPercentage { get; set; }
        public string ICertificate { get; set; }
        public HttpPostedFileBase Iimage { get; set; }
        public string ICollegeName { get; set; }
    }
}
