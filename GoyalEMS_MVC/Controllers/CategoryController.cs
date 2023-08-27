using GoyalEMS_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoyalEMS_MVC.Controllers
{
    public class CategoryController : Controller
    {
        DepartmentProcessor processor = new DepartmentProcessor();

        public ActionResult CategoryList()
        {
            var departments = processor.GetDepartments;
            return View(departments);
        }

        [HttpGet]
        public ActionResult AddNew()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNew(DepartmentModel model)
        {
            processor.Save(model);
            return RedirectToAction("CategoryList");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
           DepartmentModel model = processor.GetDepartment(id);
           
            if(model != null)
               return View(model);

            return RedirectToAction("CategoryList");
        }

        [HttpPost]
        public ActionResult Edit(DepartmentModel model)
        {
            processor.Update(model);
            return RedirectToAction("CategoryList");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            processor.Remove(id);
            return RedirectToAction("CategoryList");
        }
    }
}