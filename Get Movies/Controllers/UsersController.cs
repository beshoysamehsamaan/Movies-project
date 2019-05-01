using Get_Movies.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Get_Movies.ViewModels;

namespace ASP.NET.Controllers
{
    public class UsersController : Controller
    {
        [Route("test")]
        public ActionResult test()
        {
            List<ViewLog> items = new ViewLog() { User_Id = 2 }.Search(true, true).ToList();
            return Content("" + items.Count);
        }
        //----login----//
        [Route("login")]
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        [Route("login")]
        public ActionResult login(User u)
        {
            User user = u.authenticate();
            if (user != null)
            {
                ViewBag.LoginAttempt = true;
                var LoggingTypeObject = new User() { Id = user.Id }.GetUserType();
                Session["UserData"] = new User() { Id = user.Id }.Search(true, true).FirstOrDefault<User>();
                string LoggingType = LoggingTypeObject.GetType().Name;

                Session["UserType"] = ((String)LoggingType).Split('_')[0];
                Debug.WriteLine("Xxxxxxxxxxxxxxxxx" + ((String)Session["UserType"]));
            

                var loggingType = UserFactory.Build((string)Session["UserType"], user.Id);
                switch (Session["UserType"] as String)
                {
                    case "Blacklist":
                        Session["UserTypeData"] = loggingType as Blacklist;
                        break;
                    case "Admin":
                        Session["UserTypeData"] = loggingType as Admin;
                        break;
                    case "Casual":
                        Session["UserTypeData"] = loggingType as Casual;
                        break;
                    case "Premium":
                        Session["UserTypeData"] = loggingType as Premium;
                        break;
                }

                

                if (((String)Session["UserType"]).Equals("Blacklist"))
                {
                    return View();
                }
                return RedirectToAction("Home", "Users");
            }
            else
            {
                ViewBag.LoginAttempt = false;
                return View();
            }
        }
        //----signup----//
        [Route("signup")]
        public ActionResult signup()
        {
            return View();
        }
        [HttpPost]
        [Route("signup")]
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
        [Route("logout")]
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
        [Route("Users/Editprofile")]
        public ActionResult Editprofile()
        {
            User u = new User() { Id = (Session["UserData"] as User).Id }.Search(true, true).FirstOrDefault();
            ViewBag.usernameOrEmailExists = 2;
            return View(u);
        }
        [Route("Users/Editprofile")]
        [HttpPost]
        public ActionResult Editprofile(User u, string submit)
        {

            if (submit == "update")
            {

                try
                {
                    new User() { Id = (Session["UserData"] as User).Id }.Update(u, true, true);
                    ViewBag.usernameOrEmailExists = 0;
                }
                catch (Exception)
                {
                    ViewBag.usernameOrEmailExists = 1;
                }

                return View();
            }
            else if (submit == "deleteProfile")
            {
                //Debug.WriteLine("entered deleted if");
                User loggedUser = Session["UserData"] as User;
                new User() { Id = loggedUser.Id }.Remove(true, true);
                ViewBag.usernameOrEmailExists = 2;
                return RedirectToAction("Logout", "Users");
            }
            //else if (submit == "watchHistory")
            //{
            //    Debug.WriteLine("Entered watch history successfully");
            //}

            else { return View(); }
        }

        [Route("Users/WatchHistory")]
        public ActionResult WatchHistory(string submit)
        {
            if (submit == "deleteWatchHistory")
            {
                Debug.WriteLine((Session["UserData"] as User).Id);
                new ViewLog() { User_Id = (Session["UserData"] as User).Id }.Remove(true, true);
                return RedirectToAction("Editprofile", "Users");
            }

            //Debug.WriteLine((Session["UserData"] as User).Id);
            return View(new ViewLog() { User_Id = (Session["UserData"] as User).Id }.Search(true, true).ToList());


        }

    }

}
