using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using EEP_Models.Repository_Interface;

namespace EEP_Repository
{
   public class RepositoryDept: IRepositoryDept
    {
        
        public virtual int Deptadd(EEP_Models.Models.Department objbodept)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("proc_adddept",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DepId", objbodept.DeptId);
            cmd.Parameters.AddWithValue("@Deptname", objbodept.DeptName);
            cmd.Parameters.AddWithValue("@DeptRoll", objbodept.DeptRole);
            int i=cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public List<EEP_Models.Models.Department> viewdept()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            SqlDataAdapter da = new SqlDataAdapter("proc_viewdept", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds,"dept");
            List<EEP_Models.Models.Department> li = ds.Tables[0].AsEnumerable().Select(
                            dataRow => new EEP_Models.Models.Department
                            {
                                DeptId = dataRow.Field<string>("DeptId"),
                                DeptName = dataRow.Field<string>("DeptName"),
                                DeptRole = dataRow.Field<string>("DeptRoll")
                            }).ToList();
            return li;
        }
       public string GetRollNumber(string id)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            // SqlConnection con1 = new SqlConnection("user id = sa; password = abc; database = demo; data source =.");
            con.Open();
            string s = "select DeptRoll from Department where DeptId='"+id+"'";
            SqlCommand cmd = new SqlCommand(s,con);
            string a1= cmd.ExecuteScalar().ToString();
            con.Close();
            return a1;
        }
    }
}
