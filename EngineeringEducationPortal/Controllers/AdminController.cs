using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessObjects;
using EEP_DAL;
using System.Data;
namespace EngineeringEducationPortal.Controllers
{
    public class AdminController : Controller
    {
        BusinessObjects.Dept objbodept = new BusinessObjects.Dept();
        EEP_DAL.Dept objdaldept = new EEP_DAL.Dept();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddDept()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDept(FormCollection f)
        {
            objbodept.DeptId = f[1];
            objbodept.DeptName = f[2];
            objbodept.DeptRoll = f[3];
            int i= objdaldept.adddept(objbodept);
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
            List<BusinessObjects.Dept>li= objdaldept.viewdept();
            return View(li);
        }
    }
}