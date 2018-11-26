using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEP_Models.Models
{
    public class Address
    {
        public string AddressID { get; set; }
        public string Dno { get; set; }
        public string Firstline { get; set; }
        public string Secondline { get; set; }
        public string Village { get; set; }
        public string Mandal { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public int Pincode { get; set; }

    }
}
