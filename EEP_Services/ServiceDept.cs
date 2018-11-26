using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEP_Models.Models;
using EEP_Models.Service_Interface;
using EEP_Repository;
namespace EEP_Services
{
   public class ServiceDept:IServiceDept
    {
        EEP_Repository.RepositoryDept objrepdep = new RepositoryDept();
        public int serviceaddemp(EEP_Models.Models.DeptModel objbomodel)
        {
            int i= objrepdep.Deptadd(objbomodel);
            return i;
        }
        public List<EEP_Models.Models.DeptModel> viewdept()
        {
           List<EEP_Models.Models.DeptModel>li= objrepdep.viewdept();
            return li;
        }
    }
}
