using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EEP_Models.Models
{
    public class Department
    {
        [Required(ErrorMessage ="Dept id must not be empty")]
        public string DeptId { get; set; }
        [Required(ErrorMessage ="Dept Name must not be empty")]
        public string DeptName { get; set; }
        [Required(ErrorMessage ="DeptRole must not be empty")]
        public string DeptRole { get; set; }
    }
}
