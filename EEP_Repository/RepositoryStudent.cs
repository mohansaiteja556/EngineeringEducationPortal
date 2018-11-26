using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEP_Models.Repository_Interface;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace EEP_Repository
{
   public class RepositoryStudent:IRepositoryStudent
    {
        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
        public int AddStudent(EEP_Models.Models.Student s)
        {
            SqlConnection con = new SqlConnection("user id=sa;password=abc;database=demo;data source=.");
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_add", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RollNo", s.RollNo);
            cmd.Parameters.AddWithValue("@Fname", s.Fname);
            cmd.Parameters.AddWithValue("@Lname", s.Lname);
            cmd.Parameters.AddWithValue("@Fathername", s.FatherName);
            cmd.Parameters.AddWithValue("@Mothername", s.MotherName);
            cmd.Parameters.AddWithValue("@Phno", s.Phno);
            cmd.Parameters.AddWithValue("@ParentPhno", s.ParentsPhno);
            cmd.Parameters.AddWithValue("@Email", s.Email);
            cmd.Parameters.AddWithValue("@Aadhar", s.Aadhar);
            cmd.Parameters.AddWithValue("@AId", s.AddressID);
            cmd.Parameters.AddWithValue("@Bloodgroup", s.Bloodgroup);
            cmd.Parameters.AddWithValue("@Photo", s.Photo);
            cmd.Parameters.AddWithValue("@DeptId", s.DeptId);
            cmd.Parameters.AddWithValue("@Bcert", s.BCertificate);
            cmd.Parameters.AddWithValue("@Bcollegename", s.BCollegeName);
            cmd.Parameters.AddWithValue("@Bmarks", s.BMarks);
            cmd.Parameters.AddWithValue("@Firstline", s.Firstline);
            cmd.Parameters.AddWithValue("@Bper", s.BPercentage);
            cmd.Parameters.AddWithValue("@BRollno", s.BRollNo);
            cmd.Parameters.AddWithValue("@Dcert", s.DCertificate);
            cmd.Parameters.AddWithValue("@Dcollegename", s.DCollegeName);
            cmd.Parameters.AddWithValue("@District", s.District);
            cmd.Parameters.AddWithValue("@Dmarks", s.DMarks);
            cmd.Parameters.AddWithValue("@Dno", s.Dno);
            cmd.Parameters.AddWithValue("@Dper", s.DPercentage);
            cmd.Parameters.AddWithValue("@DRollno", s.DRollNo);
            cmd.Parameters.AddWithValue("@Incert", s.ICertificate);
            cmd.Parameters.AddWithValue("@Incollegename", s.ICollegeName);
            cmd.Parameters.AddWithValue("@Inmarks", s.IMarks);
            cmd.Parameters.AddWithValue("@Inper", s.IPercentage);
            cmd.Parameters.AddWithValue("@IRollno", s.IRollNo);
            cmd.Parameters.AddWithValue("@Mandal", s.Mandal);
            cmd.Parameters.AddWithValue("@PTcert", s.PCertificate);
            cmd.Parameters.AddWithValue("@PTcollegename", s.PCollegeName);
            cmd.Parameters.AddWithValue("@Pincode", s.Pincode);
            cmd.Parameters.AddWithValue("@PTmarks", s.PMarks);
            cmd.Parameters.AddWithValue("@PTper", s.PPercentage);
            cmd.Parameters.AddWithValue("@PTRollno", s.PRollNo);
            cmd.Parameters.AddWithValue("@State", s.State);
            cmd.Parameters.AddWithValue("@Tcert", s.TCertificate);
            cmd.Parameters.AddWithValue("@Tmarks", s.TMarks);
            cmd.Parameters.AddWithValue("@Tper", s.TPercentage);
            cmd.Parameters.AddWithValue("@TRollno", s.TRollNo);
            cmd.Parameters.AddWithValue("@Schoolname", s.TSchoolName);
            cmd.Parameters.AddWithValue("@Village", s.Village);
            cmd.Parameters.AddWithValue("@Secondline", s.Secondline);

            int i= cmd.ExecuteNonQuery();
            return i;

        }
    }
}
