using GoyalEMS_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoyalEMS_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDataProcessor processor = new EmployeeDataProcessor();
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel model)
        {
            if(model.ProfileImage != null)
            {
                string FolderPath = Server.MapPath("~/ProfilePictures");
                string guidId = Guid.NewGuid().ToString();
                string FileName = guidId + "_" + model.ProfileImage.FileName;
                string filepath = System.IO.Path.Combine(FolderPath, FileName);
                model.ProfileImage.SaveAs(filepath);
                model.ProfileImagePath = "/ProfilePictures/"+ FileName;
            }
            processor.Save(model);
            return View();
        }
    }
}