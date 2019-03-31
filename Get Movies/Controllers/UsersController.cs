using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASP.NET.Data;
using ASP.NET.Models;

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
        public ActionResult auth(User u)
        {
            User user = u.authenticate(u.Email,u.Password);
            if (user != null)
            {
                Session["email"] = user.Email;
                Session["username"] = user.Username;
                Session["first_name"] = user.First_Name;
                Session["last_name"] = user.Last_Name; 
                Session["profile_picture"] = user.Profile_Picture;
                return View();
            }
            else
            {
                return RedirectToAction("unauthorized", "Users");
            }
        }
        public ActionResult unauthorized()
        {
            return View();
        }
        //----signup----//
        public ActionResult signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult adduser(User u)
        {
            u.Verified = 0;
            u.Add();
            return View();
        }
        //---logout----//
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("login", "Users");
        }
    }
}
