using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EEP_Models.Models
{
    public class Tenth
    {
        public string TRollNo { get; set; }
        public int TMarks { get; set; }
        public double TPercentage { get; set; }
        public string TCertificate { get; set; }
        public HttpPostedFileBase Timage { get; set; }
        public string TSchoolName { get; set; }
    }
}
