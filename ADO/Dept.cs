using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace EEP_DAL
{
   public class Dept
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
        public int adddept(BusinessObjects.Dept objbodept)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("proc_adddept",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DepId", objbodept.DeptId);
            cmd.Parameters.AddWithValue("@Deptname", objbodept.DeptName);
            cmd.Parameters.AddWithValue("@DeptRoll", objbodept.DeptRoll);
            int i=cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public List<BusinessObjects.Dept> viewdept()
        {
            SqlDataAdapter da = new SqlDataAdapter("proc_viewdept", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds,"dept");
            List<BusinessObjects.Dept> li = ds.Tables[0].AsEnumerable().Select(
                            dataRow => new BusinessObjects.Dept
                            {
                                DeptId = dataRow.Field<string>("DeptId"),
                                DeptName = dataRow.Field<string>("DeptName"),
                                DeptRoll = dataRow.Field<string>("DeptRoll")
                            }).ToList();
            return li;
        }
    }
}
