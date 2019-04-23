﻿using Get_Movies.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

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
                switch ((String)Session["UserType"])
                {
                    case "Blacklist":
                        Session["UserTypeData"] = new Blacklist() {User_Id = user.Id}.Search(true,true).FirstOrDefault();
                        break;
                    case "Admin":
                        Session["UserTypeData"] = new Admin() {User_Id = user.Id }.Search(true,true).FirstOrDefault();
                        break;
                    case "Premium":
                        Session["UserTypeData"] = new Premium() {User_Id = user.Id }.Search(true,true).FirstOrDefault();
                        break;
                    case "Casual":
                        Session["UserTypeData"] = new Casual() {User_Id = user.Id }.Search(true,true).FirstOrDefault();
                        break;
                }
                if (((String)Session["UserType"]).Equals("Blacklist"))
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
            User u = new User() { Id = 2 }.Search(true, true).FirstOrDefault();
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
                    new User() { Id = 2 }.Update(u, true, true);
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
                Debug.WriteLine("ntered deleted if");
                User loggedUser = Session["UserData"] as User;
                new User() { Id = loggedUser.Id }.Remove(true, true);
                ViewBag.usernameOrEmailExists = 2;
                return RedirectToAction("Logout", "Users");
            }
            else { return View(); }
        }
    }
}
