namespace Get_Movies.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Get_Movies.Data;
    using Get_Movies.Models;
    //Get_Movies.Migrations.Configuration
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
                Password = "12345678",
                First_Name = "user 1",
                Last_Name = "xxxx",
                Profile_Picture = "www.text2image.com/user_images/text2image_A31887_20190405_000906.jpg",
                Verified = 0
            };
            u1.Add();
            new Admin() { User_Id = u1.Id }.Add();

            User u2 = new User
            {
                Email = "user2@gmail.com",
                Username = "user2",
                Password = "12345678",
                First_Name = "user 2",
                Last_Name = "xxxx",
                Profile_Picture = "www.text2image.com/user_images/text2image_A31887_20190405_002441.jpg",
                Verified = 0
            };
            u2.Add();
            Premium prem = new Premium() { User_Id = u2.Id };prem.Add();

            User u3 = new User
            {
                Email = "user3@gmail.com",
                Username = "user3",
                Password = "12345678",
                First_Name = "user 3",
                Last_Name = "xxxx",
                Profile_Picture = "www.text2image.com/user_images/text2image_A31887_20190405_005341.jpg",
                Verified = 0
            };
            u3.Add();
            new Casual() { User_Id = u3.Id }.Add();

            User u4 = new User
            {
                Email = "user4@gmail.com",
                Username = "user4",
                Password = "12345678",
                First_Name = "user 4",
                Last_Name = "xxxx",
                Profile_Picture = "www.text2image.com/user_images/text2image_A31887_20190405_005609.jpg",
                Verified = 0
            };
            u4.Add();
            new Blacklist() { User_Id = u4.Id, Reason = "Ban Testing", End_Date = "04/06/2019" }.Add();

            Genre gen1 = new Genre() { Genre_ = "Action" }; gen1.Add();
            Genre gen2 = new Genre() { Genre_ = "Adventure" }; gen2.Add();
            Genre gen3 = new Genre() { Genre_ = "Animation" }; gen3.Add();
            Genre gen4 = new Genre() { Genre_ = "Biography" }; gen4.Add();
            Genre gen5 = new Genre() { Genre_ = "Comedy" }; gen5.Add();
            Genre gen6 = new Genre() { Genre_ = "Crime" }; gen6.Add();
            Genre gen7 = new Genre() { Genre_ = "Documentary" }; gen7.Add();
            Genre gen8 = new Genre() { Genre_ = "Drama" }; gen8.Add();
            Genre gen9 = new Genre() { Genre_ = "Family" }; gen9.Add();
            Genre gen10 = new Genre() { Genre_ = "Fantasy" }; gen10.Add();
            Genre gen11 = new Genre() { Genre_ = "Film-Noir" }; gen11.Add();
            Genre gen12 = new Genre() { Genre_ = "History" }; gen12.Add();
            Genre gen13 = new Genre() { Genre_ = "Horror" }; gen13.Add();
            Genre gen14 = new Genre() { Genre_ = "Music" }; gen14.Add();
            Genre gen15 = new Genre() { Genre_ = "Musical" }; gen15.Add();
            Genre gen16 = new Genre() { Genre_ = "Mystery" }; gen16.Add();
            Genre gen17 = new Genre() { Genre_ = "Romance" }; gen17.Add();
            Genre gen18 = new Genre() { Genre_ = "Sci-Fi" }; gen18.Add();
            Genre gen19 = new Genre() { Genre_ = "Sport" }; gen19.Add();
            Genre gen20 = new Genre() { Genre_ = "Thriller" }; gen20.Add();
            Genre gen21 = new Genre() { Genre_ = "War" }; gen21.Add();
            Genre gen22 = new Genre() { Genre_ = "Western" }; gen22.Add();

            Movie m1 = new Movie()
            {
                Title = "RED",
                Genre_Id = 1,
                Director = "Robert Schwentke",
                Release_Date = "12/05/2010",
                Poster = "en.wikipedia.org/wiki/Red_(2010_film)#/media/File:Red_ver7.jpg",
                Rating_Count = 0,
                View_Count = 0
            };
            m1.Add();
            Movie m2 = new Movie()
            {
                Title = "RED 2",
                Genre_Id = 1,
                Director = "Dean Parisot",
                Release_Date = "12/05/2016",
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

            AdRequest ar = new AdRequest() { Email = "proposer@gmail.com", Note = "Negotiation Terms", Image = "www.text2image.com/user_images/text2image_A31887_20190406_022910.jpg", Start_Date = "10/10/2019", Approved = 0 };
            ar.Add();

            ViewLog vl = new ViewLog() { User_Id = 3, Movie_Id = 1, Time_Stamp = DateTime.Now.ToString("dddd, dd MMMM yyyy")};
            vl.Add();
        }
    }
}
