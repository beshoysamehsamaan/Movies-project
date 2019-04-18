using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Get_Movies.Data;
using Get_Movies.Models;

namespace ASP.NET.Controllers
{
    public class UsersController : Controller
    {
        [Route("test")]
        public ActionResult test()
        {
            return Content("");
        }
        //----login----//
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(User u)
        {
            User user = u.authenticate();
            if (user != null)
            {
                ViewBag.LoginAttempt = true;
                var LoggingTypeObject = new User() { Id = user.Id }.GetUserType();
                string LoggingType = LoggingTypeObject.GetType().Name;
                switch(LoggingType)
                {
                    case "Blacklist":
                        Session["UserData"] = new Blacklist() {User_Id = LoggingTypeObject.User_Id}.Search(true,true).FirstOrDefault();
                        break;
                    case "Admin":
                        Session["UserData"] = new Admin() {User_Id = LoggingTypeObject.User_Id}.Search(true,true).FirstOrDefault();
                        break;
                    case "Premium":
                        Session["UserData"] = new Premium() {User_Id = LoggingTypeObject.User_Id}.Search(true,true).FirstOrDefault();
                        break;
                    case "Casual":
                        Session["UserData"] = new Casual() {User_Id = LoggingTypeObject.User_Id}.Search(true,true).FirstOrDefault();
                        break;
                }
                Session["UserType"] = LoggingType;
                if (LoggingType.Equals("Blacklist"))
                {
                    return View();
                }
                return RedirectToAction("Home","Users");
            }
            else
            {
                ViewBag.LoginAttempt = false;
                return View();
            }
        }
        //----signup----//
        public ActionResult signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult signup(User u)
        {
            Boolean Validation;
            //Start Code to validate
            Validation = true;
            //Validation = "Error Type";
            //End   Code to validate
            if (Validation)
            {
                u.Verified = 0;
                u.Add();
                ViewBag.SignupAttempt = true;
                ModelState.Clear();
            }
            return View();
        }
        //---logout----//
        public ActionResult Logout()
        {
            ViewBag.LoginAttempt = null;
            Session.Clear();
            return RedirectToAction("Home", "Users");
        }
        //---home----//
        [Route("")]
        public ActionResult Home()
        {
            return RedirectToAction("Page", "Movies", new RouteValueDictionary { { "PageNum", 1 } });
        }
    }
}
