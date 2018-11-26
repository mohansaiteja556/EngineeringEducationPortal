using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using EEP_Services;
using EEP_Models;
namespace EngineeringEducationPortal.Controllers
{
    public class AdminController : Controller
    {
        EEP_Models.Models.DeptModel objbodept = new EEP_Models.Models.DeptModel();
        EEP_Services.ServiceDept objdepservice = new ServiceDept();
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
        public ActionResult AddDept(EEP_Models.Models.DeptModel objmodel)
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
            List<EEP_Models.Models.DeptModel>li= objdepservice.viewdept();
            return View(li);
        }
        public ActionResult AddStudent()
        {
            List<EEP_Models.Models.DeptModel> li = objdepservice.viewdept();
            List<SelectListItem> lidept = new List<SelectListItem>();
            lidept.Add(new SelectListItem { Text = "select Department", Value = "0" });
            foreach (var item in li)
            {
                lidept.Add(new SelectListItem { Text = item.DeptName, Value = item.DeptId });
            }
            ViewData["Department"] = lidept;
            return View();
        }
    }
}