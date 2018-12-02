using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EEP_Models.Models
{
   public class Degree
    {
        public string DRollNo { get; set; }
        public int DMarks { get; set; }
        public double DPercentage { get; set; }
        public string DCertificate { get; set; }
        public HttpPostedFileBase Dimage { get; set; }
        public string DCollegeName { get; set; }
    }
}
