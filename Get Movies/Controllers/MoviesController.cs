using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Get_Movies.Models;
using Get_Movies.ViewModels;
using System.Web.Mvc;

namespace Get_Movies.Controllers
{
    public class MoviesController : Controller
    {
        /*Start Front Page*/
        [Route("Page/{PageNum}")]
        public ActionResult Page(int PageNum)
        {
            Get_Movies.Data.GetMoviesContext context = Get_Movies.Data.GetMoviesContext.GetInstance();
            context.Users.RemoveRange(null);

            int moviesPerPage = 25;
            MoviesPagination pagination = new Movie().ListLatest((PageNum - 1) * moviesPerPage, moviesPerPage);
            pagination.PageNum = PageNum;
            pagination.PagesCount = (int)Math.Ceiling((double)pagination.WholeListCount / (double)moviesPerPage);
            return View(pagination);
        }
        [HttpPost]
        [Route("Page/{PageNum}")]
        public ActionResult Page(Movie m)
        {
            int PageNum = 1;
            int moviesPerPage = new Movie().ListAll().Count();
            MoviesPagination pagination = new Movie().SearchMovie((PageNum - 1) * moviesPerPage, moviesPerPage, m.Title, m.Director, m.Release_Year, m.Genre_Id);
            pagination.PageNum = PageNum;
            pagination.PagesCount = (int)Math.Ceiling((double)pagination.WholeListCount / (double)moviesPerPage);
            if (pagination.MoviesList.Count() == 0) { ViewBag.MovieSearch404 = true; }
            return View(pagination);
        }
        /*End Front Page*/

    }
}
            