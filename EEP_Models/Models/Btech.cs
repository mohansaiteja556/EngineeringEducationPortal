using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EEP_Models.Models
{
     public class Btech
    {
        public string BtechRollNo { get; set; }
        public int BMarks { get; set; }
        public double BPercentage { get; set; }
        public string BCertificate { get; set; }
        public HttpPostedFileBase Bimage { get; set; }
        public string BCollegeName { get; set; }
    }
}
