using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEP_Models.Models;
namespace EEP_Models.Service_Interface
{
   public  interface IServiceDept
    {
        int serviceaddemp(EEP_Models.Models.Department objbomodel);
        List<EEP_Models.Models.Department> viewdept();
        string GetRollNumber(string id);
    }
}
