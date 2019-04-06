namespace Get_Movies.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Get_Movies.Data;
    using Get_Movies.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Get_Movies.Data.GetMoviesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations";
        }

        protected override void Seed(GetMoviesContext context)
        {
            User u1 = new User
            {
                Email = "user1@gmail.com",
                Username = "user1",
                Password = "1234",
                First_Name = "user 1",
                Last_Name = "x",
                Profile_Picture = "www.text2image.com/user_images/text2image_A31887_20190405_000906.jpg",
                Verified = 0
            };
            u1.Add();
            new Admin() { User_Id = u1.Id }.Add();

            User u2 = new User
            {
                Email = "user2@gmail.com",
                Username = "user2",
                Password = "1234",
                First_Name = "user 2",
                Last_Name = "x",
                Profile_Picture = "www.text2image.com/user_images/text2image_A31887_20190405_002441.jpg",
                Verified = 0
            };
            u2.Add();
            Premium prem = new Premium() { User_Id = u2.Id };prem.Add();

            User u3 = new User
            {
                Email = "user3@gmail.com",
                Username = "user3",
                Password = "1234",
                First_Name = "user 3",
                Last_Name = "x",
                Profile_Picture = "www.text2image.com/user_images/text2image_A31887_20190405_005341.jpg",
                Verified = 0
            };
            u3.Add();
            new Casual() { User_Id = u3.Id }.Add();

            User u4 = new User
            {
                Email = "user4@gmail.com",
                Username = "user4",
                Password = "1234",
                First_Name = "user 4",
                Last_Name = "x",
                Profile_Picture = "www.text2image.com/user_images/text2image_A31887_20190405_005609.jpg",
                Verified = 0
            };
            u4.Add();
            new Blacklist() { User_Id = u4.Id, Reason = "Ban Testing", End_Date = "04/06/2019" }.Add();

            Movie m1 = new Movie()
            {
                Title = "RED",
                Genre = "Action",
                Director = "Robert Schwentke",
                Release_date = "12/05/2010",
                Poster = "en.wikipedia.org/wiki/Red_(2010_film)#/media/File:Red_ver7.jpg",
                Rating_Count = 0,
                View_Count = 0
            };
            m1.Add();
            Movie m2 = new Movie()
            {
                Title = "RED 2",
                Genre = "Action",
                Director = "Dean Parisot",
                Release_date = "12/05/2016",
                Poster = "en.wikipedia.org/wiki/Red_2_(film)#/media/File:RED_2_poster.jpg",
                Rating_Count = 0,
                View_Count = 0
            };
            m2.Add();

            Playlist pl1 = new Playlist() { Premium_Id = prem.Id, Title = "Playlist1" };
            pl1.Add();

            MoviePlaylist m1pl1 = new MoviePlaylist() { Movie_Id = m1.Id, Playlist_Id = pl1.Id };
            m1pl1.Add();

            MoviePlaylist m2pl1 = new MoviePlaylist() { Movie_Id = m2.Id, Playlist_Id = pl1.Id };
            m2pl1.Add();

            Rating r1 = new Rating() { User_Id = u1.Id, Movie_Id = m1.Id, Rating_ = 4 }; r1.Add();
            Rating r2 = new Rating() { User_Id = u2.Id, Movie_Id = m2.Id, Rating_ = 5 }; r2.Add();

            MovieRequest mr = new MovieRequest() { Premium_Id = prem.Id, Title = "Requested Movie", Note = "Note" };

            AdRequest ar = new AdRequest() { Email = "proposer@gmail.com", Note = "Negotiation Terms", Image = "www.text2image.com/user_images/text2image_A31887_20190406_022910.jpg", Start_Date = "", Approved = 0 };
            ar.Add();
        }
    }
}
