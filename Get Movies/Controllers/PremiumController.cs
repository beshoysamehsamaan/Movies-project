using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Get_Movies.Models;
using Get_Movies.ViewModels;

namespace Get_Movies.Controllers
{
    public class PremiumController : Controller
    {
        // GET: Premium
        [Route("Premium/createplaylist")]
        public ActionResult createplaylist()
        {
            return View();
        }
        [Route("Premium/createplaylist")]
        [HttpPost]
        public ActionResult createplaylist(Playlist p)
        {
            p.Premium_Id = (Session["UserTypeData"] as Premium).Id;
            p.Add();
            return View();
        }

        [Route("Premium/playlists")]
        public ActionResult playlists()
        {

            var p = new Playlist() { Premium_Id = (Session["UserTypeData"] as Premium).Id }.Search(true, true);
            ViewBag.p = p;
            ViewBag.ii = true;
            return View(new Playlist() { Premium_Id = (Session["UserTypeData"] as Premium).Id }.Search(true, true).ToList());
        }
        [Route("Premium/playlists")]
        [HttpPost]
        public ActionResult playlists(Playlist p ,int id,string submit)
        {
            if (submit == "Show Movies")
            {
              
              
                return View(new Playlist() { Premium_Id = (Session["UserTypeData"] as Premium).Id }.Search(true, true).ToList());
            }
            
                else if (submit == "Delete Playlist")
                {

                    new Playlist() { Id = id }.Remove(true, true);
                    return View(new Playlist() {Premium_Id=1 }.Search(true,true).ToList());
                }
                else
                {
                    return View(new Playlist() { Premium_Id = (Session["UserTypeData"] as Premium).Id }.Search(true, true).ToList());
                }


               
        }
        [HttpPost]
        [Route("Premium/AddMovieToPlaylist")]
        public ActionResult AddMovieToPlaylist(AddMovieToPlaylist data)
        {
            //Debug.WriteLine("xxxxxxxxxxxxxxxxxx"+ data.movieId + "xxxxxxxxxxxxxxxxx" + data.playlistId);
            new PlaylistMovie() { Movie_Id = data.movieId, Playlist_Id = data.playlistId }.Add();
            return RedirectToAction("Page","Movies",new { PageNum=1});
        }
    }
}