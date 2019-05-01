using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Get_Movies.Models;

namespace Get_Movies.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        [Route("Admin/addmovie")]
        public ActionResult addmovie()
        {
            return View();
        }
        [Route("Admin/addmovie")]
        [HttpPost]
        public ActionResult addmovie(Movie m)
        {
            
            m.Views_Count = 0;
            m.Genre_Id = 3;

            m.Add();


            return View();
        }
        [Route("Admin/listmovie")]
        public ActionResult listmovie()
        {
            var m = new Movie().ListAll();
            ViewBag.m = m;
            ViewBag.ii = true;
            return View();
        }
        [Route("Admin/listmovie")]
        [HttpPost]
        public ActionResult listmovie(Movie i)
        {
            if (i.Title != "")
            {
                ViewBag.i = new Movie { Title = i.Title }.Search(false, false);
                ViewBag.ii = false;
            }

            return View();
        }
        [Route("Admin/deletemovie")]
        public ActionResult deletemovie()
        {
            ViewBag.x = 1;
            return View();
        }
        [Route("Admin/deletemovie")]
        [HttpPost]
        public ActionResult deletemovie(Movie i, Movie u, string submit)
        {
            if (submit == "submit")
            {
                try
                {
                    ViewBag.v = new Movie() { Id = i.Id }.Search(true, true).FirstOrDefault();
                    if (i.Id != null && ViewBag.v != null)
                    {
                        u = new Movie() { Id = i.Id }.Search(true, true).FirstOrDefault();
                        ViewBag.x = 0;

                    }
                }
                catch
                {

                }
                return View(u);
            }
            else
            {
                if (submit == "Ubdate")
                {


                    
                    Debug.WriteLine("XXXXXXXXXXXXX"+u.Id);
                    Debug.WriteLine("XXXXXXXXXXXXX" + u.Title);
                    Debug.WriteLine("XXXXXXXXXXXXX" + u.Description);

                    new Movie() { Id = u.Id }.Update(new Movie() { Title=u.Title,Description=u.Description}, true, true);
                    ViewBag.x = 0;
                    return View(u);

                }
                else if (submit == "Delete")
                {

                    new Movie() { Id = u.Id }.Remove(true, true);
                    //u = new Movie() { Id = u.Id }.Search(true, true).FirstOrDefault();
                    ViewBag.x = 0;

                    return View();

                }
                else
                {
                    return View(u);
                }

            }
        }

        [Route("Admin/banuser")]
        public ActionResult banuser()
        {
            var m = new User().ListAll();
            var s = new Blacklist().ListAll();
            ViewBag.t = m;
            ViewBag.tt = s;
            ViewBag.ty = 1;
            return View();
        }
        [Route("Admin/banuser")]
        [HttpPost]
        public ActionResult banuser(User i)
        {
            if (i.First_Name == "Deactivate")
            {
                Blacklist b = new Blacklist() { User_Id = i.Id, Reason = "admin is midya2", End_Date = "10/10/2020" };
                b.Add();
                var m = new User().ListAll();
                var s = new Blacklist().ListAll();
                ViewBag.t = m;
                ViewBag.tt = s;
            }
            else if (i.First_Name == "Activate")
            {
                new Blacklist()
                {
                    User_Id = i.Id
                }.Remove(true, true);
            }
            return RedirectToAction("banuser", "Admin");
        }
        [Route("Admin/movierequest")]
        public ActionResult movierequest()
        {
            var mr = new MovieRequest().ListAll();
            ViewBag.mr = mr;
            ViewBag.ii = true;
            return View();
        }
        [Route("Admin/movierequest")]
        [HttpPost]
        public ActionResult movierequest(MovieRequest i)
        {
            if (i.Title != "")
            {
                ViewBag.i = new MovieRequest { Title = i.Title }.Search(false, false);
                ViewBag.ii = false;
            }

            return View();
        }


    }

   
}