﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Get_Movies.Data;
using Get_Movies.Models;

namespace ASP.NET.Controllers
{
    public class UsersController : Controller
    {
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
                        Session["LoggingTypeDetails"] = new Blacklist() { Id = LoggingTypeObject.Id, User_Id = LoggingTypeObject.User_Id};
                        break;
                    case "Admin":
                        Session["LoggingTypeDetails"] = new Admin() { Id = LoggingTypeObject.Id, User_Id = LoggingTypeObject.User_Id };
                        break;
                    case "Premium":
                        Session["LoggingTypeDetails"] = new Premium() { Id = LoggingTypeObject.Id, User_Id = LoggingTypeObject.User_Id };
                        break;
                    case "Casual":
                        Session["LoggingTypeDetails"] = new Casual() { Id = LoggingTypeObject.Id, User_Id = LoggingTypeObject.User_Id };
                        break;
                }
                Session["LoggingUserDetails"] = user;
                Session["LoggingType"] = LoggingType;
                return Content("Logged In Successfully");
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
            return RedirectToAction("login", "Users");
        }
        //---home----//
        public ActionResult home()
        {
            return View();
        }
    }
}
