﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Get_Movies.Models;
using Get_Movies.ViewModels;
using System.Web.Mvc;
using System.Web.Routing;

namespace Get_Movies.Controllers
{
    public class MoviesController : Controller
    {
        /*Start Front Page*/
        [Route("Page/{PageNum}")]
        public ActionResult Page(int PageNum)
        {
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
        /*Start View Page*/
        [Route("{imdbId}/View")]
        public ActionResult ViewMovie(string imdbId)
        {

            Movie toWatch = new Movie() { Imdb_Id = imdbId }.Search(true, true).FirstOrDefault();
            if (Session["UserData"] != null)
            {


                User watcher = Session["UserData"] as User; toWatch.View(watcher.Id.Value);

            }
            return View(toWatch);
        }
        [HttpPost]
        [Route("Movies/Rate")]
        public ActionResult RateMovie(int Movie_Id,String imdb_Id,int submit)
        {
            if (submit == 1 || submit == 2 || submit == 3 || submit == 4 || submit == 5)
            {
                Rating toRate = new Rating { User_Id = (Session["UserData"] as User).Id, Rating_ = submit, Movie_Id = Movie_Id };
                toRate.Add();
            }
            return RedirectToAction("ViewMovie", "Movies", new RouteValueDictionary() { {"imdbId",imdb_Id } });
        }
        /*End   View Page*/
    }
}
