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
        public ActionResult test()
        {
            //User u = new User()
            //{
            //    Email = "mina14gerges14@gmail.com",
            //    Username = "mina1234",
            //    Password = "1234",
            //    First_Name = "Mina",
            //    Last_Name = "Mina",
            //    Profile_Picture = "1.com",
            //    Verified = 0
            //};
            //u.Add();

            //Admin a = new Admin() { User_Id = 1 };
            //GetMoviesContext.GetInstance().Admins.Add(a);
            //Casual c = new Casual() { User_Id = 1 };
            //GetMoviesContext.GetInstance().Casuals.Add(c);

            //Premium p = new Premium() { User_Id = 2 };
            //GetMoviesContext.GetInstance().Premiums.Add(p);

            //Blacklist bl = new Blacklist() { User_Id = 2 };
            //GetMoviesContext.GetInstance().Blacklist.Add(bl);

            //MovieRequest mreq = new MovieRequest() { Use_Id = 2 };
            //GetMoviesContext.GetInstance().MovieRequests.Add(mreq);

            //AdRequest areq = new AdRequest() { Email="a"};
            //GetMoviesContext.GetInstance().AdRequests.Add(areq);

            //Movie m = new Movie() {};
            //GetMoviesContext.GetInstance().Movies.Add(m);

            //Playlist pl = new Playlist() { Premium_Id=3};
            //GetMoviesContext.GetInstance().Playlists.Add(pl);

            //Rating r = new Rating() { User_Id = 4, Movie_Id=5,Rating_=5};
            //GetMoviesContext.GetInstance().Ratings.Add(r);

            //MoviePlaylist mpl = new MoviePlaylist() { Movie_Id = 5, Playlist_Id = 5};
            //GetMoviesContext.GetInstance().MoviePlaylists.Add(mpl);

            GetMoviesContext.GetInstance().SaveChanges();
            return Content("Done Correctly");
        }
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
