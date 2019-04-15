using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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

        public ActionResult addmovie()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addmovie(Movie m)
        {
                m.Rating_Count = 0;
                m.View_Count = 0;
                m.Genre_Id = 3;
                m.Add();
            return View();
        }

        public ActionResult deletemovie()
        {
            return View();
        }

        [HttpPost]
        public ActionResult deletemovie(Movie m)
        {
            m.Remove(false, false);
            Debug.WriteLine("xxxxxxxxxxxx" + m.Title);
            Debug.WriteLine("xxxxxxxxxxxx" + m.Search(false, true) == null);
            return View();
        }


    }
}