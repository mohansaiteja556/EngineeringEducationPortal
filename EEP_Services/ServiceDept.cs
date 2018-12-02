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
        public int serviceaddemp(EEP_Models.Models.Department objbomodel)
        {
            int i= objrepdep.Deptadd(objbomodel);
            return i;
        }
        public List<EEP_Models.Models.Department> viewdept()
        {
           List<EEP_Models.Models.Department>li= objrepdep.viewdept();
            return li;
        }
        public string GetRollNumber(string id)
        {
            string s= objrepdep.GetRollNumber(id);
            char[] ch = s.ToCharArray();
            string[] s1;
            string n="";
            int a = 0;
            for (int i=0;i<=ch.Length-1;i++)
            {
                if(ch[i]=='A')
                {
                   s1 = s.Split('A');
                    a = int.Parse(s1[1]);
                    a++;
                    n = s1[0] + "A" +"0"+ a;
                }
                if (s[i] == 'B')
                {
                    s1 = s.Split('B');
                    a = int.Parse(s1[1]);
                    a++;
                    n = s1[0] + "B" + a;
                }
            }
            return n;
        }
    }
}
