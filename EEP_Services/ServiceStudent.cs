using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEP_Models.Service_Interface;
using EEP_Repository;
namespace EEP_Services
{
   public class ServiceStudent:IServiceStudent
    {
        EEP_Repository.RepositoryStudent objrepstudent = new RepositoryStudent();
       public int addstudent(EEP_Models.Models.Student s)
        {
            int i= objrepstudent.AddStudent(s);
            return i;
        }
    }
}
