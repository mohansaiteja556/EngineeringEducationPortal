using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEP_Models.Service_Interface;
using EEP_Models.Models;
using EEP_Repository;
namespace EEP_Services
{
   public class ServiceAuto:IServiceAuto
    {
        EEP_Repository.RepositoryAuto objreauto = new RepositoryAuto();
       public string Getauto(EEP_Models.Models.Auto objauto)
        {
            string s= objreauto.Getauto(objauto);
           string[]s1= s.Split('_');
            int a = int.Parse(s1[1]);
            a++;
            string id = s1[0] + "_" + a;
            return id;
        }
    }
}
