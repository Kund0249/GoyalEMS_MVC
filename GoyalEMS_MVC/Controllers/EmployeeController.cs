using GoyalEMS_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoyalEMS_MVC.Controllers
{
    //[Authorize]
    public class EmployeeController : Controller
    {
        EmployeeDataProcessor processor = new EmployeeDataProcessor();

        public ActionResult EmployeeList(EmployeeFilterModel filterModel,int? PageNumber)
        {
            EmployeeWrapper wrapper = new EmployeeWrapper();
            wrapper.Employees = processor.GetEmployees(filterModel.EmpCode, filterModel.Email).Skip(((PageNumber ?? 1) - 1) * wrapper.PageSize).Take(wrapper.PageSize).ToList();
            wrapper.PageNumber = (PageNumber ?? 1);
            wrapper.TotalPages = processor.GetEmployees(filterModel.EmpCode, filterModel.Email).Count();
            return View(wrapper);
        }

        [HttpPost]
        public ActionResult FilteredEmployee(int EmployeeCode = 0, string EmployeeEmail = null)
        {
            return RedirectToAction("EmployeeList", new { EmpCode = EmployeeCode, Email = EmployeeEmail });
        }

       
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.ProfileImage != null)
                {
                    string FolderPath = Server.MapPath("~/ProfilePictures");
                    string guidId = Guid.NewGuid().ToString();
                    string FileName = guidId + "_" + model.ProfileImage.FileName;
                    string filepath = System.IO.Path.Combine(FolderPath, FileName);
                    model.ProfileImage.SaveAs(filepath);
                    model.ProfileImagePath = "/ProfilePictures/" + FileName;
                }
                processor.Save(model);
            }

            return View();
        }
    }
}