using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoyalEMS_MVC.Models;

namespace GoyalEMS_MVC.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentRepository repo = new DepartmentRepository();
        [HttpGet]
        public ViewResult Index()
        {
            List<DepartmentModel> departments = repo.GetDepartments;
            return View(departments);
        }

        //[HttpPost]
        //public ViewResult Save(string txtDepartmentCode,string txtDepartmentName)
        //{
        //    return View();
        //}

        [HttpPost]
        public RedirectToRouteResult Save(DepartmentModel model)
        {
            repo.Save(model);
            return RedirectToAction("Index");
        }
    }
}