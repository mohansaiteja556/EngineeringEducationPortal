using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using EEP_Services;
using EEP_Models;
using System.IO;
using EEP_Repository;

namespace EngineeringEducationPortal.Controllers
{
    public class AdminController : Controller
    {

        EEP_Models.Models.Department objbodept = new EEP_Models.Models.Department();
      // EEP_Repository.RepositoryDept repositoryDept = new RepositoryDept();
         EEP_Services.ServiceDept objdepservice = new ServiceDept(new RepositoryDept());
        EEP_Services.ServiceAuto objsauto = new ServiceAuto();
        EEP_Models.Models.Auto objboauto = new EEP_Models.Models.Auto();
        // GET: Admin
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        public ActionResult AddDept()
        {
            objboauto.TableName = "Department";
            objboauto.ColunmName = "DeptId";
            objbodept.DeptId = objsauto.Getauto(objboauto);
            return View(objbodept);
        }
        [HttpPost]
        public ActionResult AddDept(EEP_Models.Models.Department objmodel)
        {
            
            int i = objdepservice.serviceaddemp(objmodel);
            if(i==1)
            {
                ViewData["a"] = "Added successfully";
            }
            else
            {
                ViewData["a"] = "failed";
            }
            return View();
        }
        public ActionResult viewdept()
        {
            // List<BusinessObjects.Dept>li= objdaldept.viewdept();
            List<EEP_Models.Models.Department>li= objdepservice.viewdept();
            return View(li);
        }
        [HttpGet]
        public ActionResult AddStudent()
        {
            List<EEP_Models.Models.Department> li = objdepservice.viewdept();
            List<SelectListItem> lidept = new List<SelectListItem>();
            lidept.Add(new SelectListItem { Text = "select Department", Value = "0" });
            foreach (var item in li)
            {
                lidept.Add(new SelectListItem { Text = item.DeptName, Value = item.DeptId });
            }
            ViewData["Department"] = lidept;
            List<SelectListItem> studenttype = new List<SelectListItem>();
            studenttype.Add(new SelectListItem { Text = "Select student Type", Value = "0" });
            studenttype.Add(new SelectListItem { Text = "Btech", Value = "1" });
            studenttype.Add(new SelectListItem { Text = "Btech With PT", Value = "2" });
            studenttype.Add(new SelectListItem { Text = "MCA", Value = "3" });
            studenttype.Add(new SelectListItem { Text = "MTech", Value = "4" });
            ViewData["StudentType"] = studenttype;
            List<SelectListItem> BloodGroup = new List<SelectListItem>();
            BloodGroup.Add(new SelectListItem { Text = "Select BloodGroup", Value = "BG" });
            BloodGroup.Add(new SelectListItem { Text = "O+", Value = "O+" });
            BloodGroup.Add(new SelectListItem { Text = "AB+", Value = "AB+" });
            BloodGroup.Add(new SelectListItem { Text = "A+", Value = "A+" });
            BloodGroup.Add(new SelectListItem { Text = "B+", Value = "B+" });
            ViewData["BloodGroup"] = BloodGroup;
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(EEP_Models.Models.Student s)
        {
            if (s.btechDetails.BtechRollNo == null || s.degreeDetails.DRollNo==null)
            {
                //adding photo
                string filename = Path.GetFileName(s.image.FileName);
                string filexe = Path.GetExtension(s.image.FileName);
                s.Photo = "~/StudentImages/" +s.RollNo + filename;
                filename = Path.Combine(Server.MapPath("~/StudentImages/"), filename);
                s.image.SaveAs(filename);
                //adding tenth certiicate
                string filename1 = Path.GetFileName(s.tenthDetails.Timage.FileName);
                string filexe1 = Path.GetExtension(s.tenthDetails.Timage.FileName);
                s.tenthDetails.TCertificate = "~/StudentCertificate/Tenth/" + s.RollNo + filename1;
                //string a1 = filename1 + s.RollNo + filexe1;
                filename1 = Path.Combine(Server.MapPath("~/StudentCertificate/Tenth/"), filename1);
                s.image.SaveAs(filename1);
                //adding inter certificate
                string filename2 = Path.GetFileName(s.interDetails.Iimage.FileName);
                string filexe2 = Path.GetExtension(s.interDetails.Iimage.FileName);
                s.tenthDetails.TCertificate = "~/StudentCertificate/Inter/"+ s.RollNo +filename2;
               // string a2 = filename2 + s.RollNo + filexe2;
                filename2 = Path.Combine(Server.MapPath("~/StudentCertificate/Inter/"), filename2);
                s.image.SaveAs(filename2);

            }


            EEP_Services.ServiceStudent obj = new ServiceStudent();
           int i= obj.addstudent(s);
            if(i==1)
            {
                ViewData["message"] = "Add Successfully";
            }
            return View();
        }
        public JsonResult GetRollNumber(string id)
        {
            string s=objdepservice.GetRollNumber(id);
            return Json(s, JsonRequestBehavior.AllowGet);
        }
    }
}