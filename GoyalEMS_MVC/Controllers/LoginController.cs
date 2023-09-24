using GoyalEMS_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace GoyalEMS_MVC.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AppUser user)
        {
            if (LoginModel.IsValid(user))
            {
                //code to login
              FormsAuthentication.RedirectFromLoginPage(user.UserName, false);
            }
            ViewBag.ErrorMessage = "Invalid User Name or Password!.";
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            Session.Clear();
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}