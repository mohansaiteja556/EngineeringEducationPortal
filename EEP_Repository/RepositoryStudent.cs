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
            cmd.Parameters.AddWithValue("@AId", s.StudentAddress.AddressID);
            cmd.Parameters.AddWithValue("@Bloodgroup", s.Bloodgroup);
            cmd.Parameters.AddWithValue("@Photo", s.Photo);
            cmd.Parameters.AddWithValue("@DeptId", s.studentDepartment.DeptId);
            cmd.Parameters.AddWithValue("@Bcert", s.btechDetails.BCertificate);
            cmd.Parameters.AddWithValue("@Bcollegename", s.btechDetails.BCollegeName);
            cmd.Parameters.AddWithValue("@Bmarks", s.btechDetails.BMarks);
            cmd.Parameters.AddWithValue("@Firstline", s.StudentAddress.Firstline);
            cmd.Parameters.AddWithValue("@Bper", s.btechDetails.BPercentage);
            cmd.Parameters.AddWithValue("@BRollno", s.btechDetails.BtechRollNo);
            cmd.Parameters.AddWithValue("@Dcert", s.degreeDetails.DCertificate);
            cmd.Parameters.AddWithValue("@Dcollegename", s.degreeDetails.DCollegeName);
            cmd.Parameters.AddWithValue("@District", s.StudentAddress.District);
            cmd.Parameters.AddWithValue("@Dmarks", s.degreeDetails.DMarks);
            cmd.Parameters.AddWithValue("@Dno", s.StudentAddress.Dno);
            cmd.Parameters.AddWithValue("@Dper", s.degreeDetails.DPercentage);
            cmd.Parameters.AddWithValue("@DRollno", s.degreeDetails.DRollNo);
            cmd.Parameters.AddWithValue("@Incert", s.interDetails.ICertificate);
            cmd.Parameters.AddWithValue("@Incollegename", s.interDetails.ICollegeName);
            cmd.Parameters.AddWithValue("@Inmarks", s.interDetails.IMarks);
            cmd.Parameters.AddWithValue("@Inper", s.interDetails.IPercentage);
            cmd.Parameters.AddWithValue("@IRollno", s.interDetails.IRollNo);
            cmd.Parameters.AddWithValue("@Mandal", s.StudentAddress.Mandal);
            cmd.Parameters.AddWithValue("@PTcert", s.polytechnicDetails.PCertificate);
            cmd.Parameters.AddWithValue("@PTcollegename", s.polytechnicDetails.PCollegeName);
            cmd.Parameters.AddWithValue("@Pincode", s.StudentAddress.Pincode);
            cmd.Parameters.AddWithValue("@PTmarks", s.polytechnicDetails.PMarks);
            cmd.Parameters.AddWithValue("@PTper", s.polytechnicDetails.PPercentage);
            cmd.Parameters.AddWithValue("@PTRollno", s.polytechnicDetails.PRollNo);
            cmd.Parameters.AddWithValue("@State", s.StudentAddress.State);
            cmd.Parameters.AddWithValue("@Tcert", s.tenthDetails.TCertificate);
            cmd.Parameters.AddWithValue("@Tmarks", s.tenthDetails.TMarks);
            cmd.Parameters.AddWithValue("@Tper", s.tenthDetails.TPercentage);
            cmd.Parameters.AddWithValue("@TRollno", s.tenthDetails.TRollNo);
            cmd.Parameters.AddWithValue("@Schoolname", s.tenthDetails.TSchoolName);
            cmd.Parameters.AddWithValue("@Village", s.StudentAddress.Village);
            cmd.Parameters.AddWithValue("@Secondline", s.StudentAddress.Secondline);

            int i= cmd.ExecuteNonQuery();
            return i;

        }
    }
}
