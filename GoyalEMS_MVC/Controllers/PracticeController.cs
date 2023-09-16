using System;
using System.Web.Mvc;
using GoyalEMS_MVC.Models;

namespace GoyalEMS_MVC.Controllers
{

    public class PracticeController : Controller
    {
        DepartmentProcessor processor = new DepartmentProcessor();

        public ActionResult TestIndex()
        {
            ViewBag.VBFruitList = new string[] { "Apple", "Mango", "Grapes" };

            ViewData["VDFruitList"] = new string[] { "Apple", "Mango", "Grapes" };
            
            ViewBag.Title = "My Test Page";
            return View();
        }

        public ActionResult Index()
        {
            return View(processor.GetDepartments);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DepartmentModel model)
        {
            processor.Save(model);
            return RedirectToAction("Index");
        }

        public ActionResult Method1()
        {
            return View();
        }


    }
}