using GoyalEMS_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoyalEMS_MVC.Controllers
{
    [HandleError(View = "_error")]
    public class DashBoardController : Controller
    {
        DepartmentProcessor processor = new DepartmentProcessor();
        // GET: DashBoard

        [OutputCache(Duration =30)]
       
        public ActionResult Index()
        {
            throw new Exception("null reference object");
            return View(processor.GetDepartments);
        }
    }
}