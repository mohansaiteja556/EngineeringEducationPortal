using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEP_Models.Models;
namespace EEP_Models.Repository_Interface
{
  public  interface IRepositoryDept
    {
        int Deptadd(EEP_Models.Models.DeptModel objbodept);
        List<EEP_Models.Models.DeptModel> viewdept();
    }
}
