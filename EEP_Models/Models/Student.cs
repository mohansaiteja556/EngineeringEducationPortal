using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEP_Models.Models
{
   public  class Student
    {
        public string RollNo { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public long Phno { get; set; }
        public long ParentsPhno { get; set; }
        public string Email { get; set; }
        public long Aadhar { get; set; }
        public string Bloodgroup { get; set; }
        public string Photo { get; set; }


        public Department studentDepartment { get; set; }
        public Address StudentAddress{ get; set; }
        
        public Btech btechDetails { get; set; }
        
        public string DRollNo { get; set; }
        public int DMarks { get; set; }
        public double DPercentage { get; set; }
        public string DCertificate { get; set; }
        public string DCollegeName { get; set; }
        public string IRollNo { get; set; }
        public int IMarks { get; set; }
        public double IPercentage { get; set; }
        public string ICertificate { get; set; }
        public string ICollegeName { get; set; }
        public string PRollNo { get; set; }
        public int PMarks { get; set; }
        public double PPercentage { get; set; }
        public string PCertificate { get; set; }
        public string PCollegeName { get; set; }
        public string TRollNo { get; set; }
        public int TMarks { get; set; }
        public double TPercentage { get; set; }
        public string TCertificate { get; set; }
        public string TSchoolName { get; set; }
    }
}
