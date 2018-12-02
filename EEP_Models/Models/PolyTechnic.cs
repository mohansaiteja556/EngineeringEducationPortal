using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EEP_Models.Models
{
    public class PolyTechnic
    {
        public string PRollNo { get; set; }
        public int PMarks { get; set; }
        public double PPercentage { get; set; }
        public string PCertificate { get; set; }
        public HttpPostedFileBase Pimage { get; set; }
        public string PCollegeName { get; set; }
    }
}
