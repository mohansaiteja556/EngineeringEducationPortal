using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEP_Models.Models;
namespace EEP_Models.Repository_Interface
{
    public interface IRepositoryStudent
    {
        int AddStudent(EEP_Models.Models.Student s);
    }
}
