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
        //test
        DepartmentProcessor processor = new DepartmentProcessor();
        [HttpGet]
        public ViewResult Index()
        {
            List<DepartmentModel> departments = processor.GetDepartments;
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
           
            processor.Save(model);
            TempData["Message"] = "Record Created!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            DepartmentModel model = processor.GetDepartment(id);
            if(model != null)
            {
                return View(model);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(DepartmentModel model)
        {
            processor.Update(model);
            return RedirectToAction("Index");
        }
    }
}