using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEP_Models.Repository_Interface;
using EEP_Models.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace EEP_Repository
{
   public class RepositoryAuto:IRepositoryAuto
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
        public string Getauto(EEP_Models.Models.Auto objauto)
        {
            con.Open();
            string s = "select "+objauto.ColunmName+" from "+objauto.TableName+" where ID in (select max(ID) from "+objauto.TableName+")";
            SqlCommand cmd = new SqlCommand(s,con);
            Object o= cmd.ExecuteScalar();
            string a=(string)o;
            return a;
        }
    }
}
