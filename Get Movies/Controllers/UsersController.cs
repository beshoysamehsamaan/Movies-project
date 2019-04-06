using System;
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
<<<<<<< Updated upstream

        public ActionResult test()
        {
            Playlist pl = new Playlist() { Id = 1 };
            pl.AddMovie(1);
            return Content("done ok");
        }
=======
        public ActionResult test(){


            Movie a1 = new Movie();
            a1.Delete(1);
            return Content("ok man");
        }


>>>>>>> Stashed changes
        //----login----//
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(User u)
        {
            User user = u.authenticate(u.Email,u.Password);
            if (user != null)
            {
                ViewBag.LoginAttempt = true; ;
                Session["email"] = user.Email;
                Session["username"] = user.Username;
                Session["first_name"] = user.First_Name;
                Session["last_name"] = user.Last_Name; 
                Session["profile_picture"] = user.Profile_Picture;
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
    }
}
