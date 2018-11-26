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
        public Degree degreeDetails { get; set; }
        public Inter interDetails { get; set; }
        public PolyTechnic polytechnicDetails { get; set; }
        public Tenth tenthDetails { get; set; }
    }
}
