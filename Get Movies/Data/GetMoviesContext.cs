using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Get_Movies.Data
{
    public class GetMoviesContext : DbContext
    {
        private static GetMoviesContext Instance = new GetMoviesContext();
        public GetMoviesContext() : base("GetMovies") { }
        public static GetMoviesContext GetInstance() {return Instance;}

        public System.Data.Entity.DbSet<Get_Movies.Models.Admin> Admins { get; set; }
        public System.Data.Entity.DbSet<Get_Movies.Models.AdRequest> AdRequests { get; set; }
        public System.Data.Entity.DbSet<Get_Movies.Models.Blacklist> Blacklist { get; set; }
        public System.Data.Entity.DbSet<Get_Movies.Models.Casual> Casuals { get; set; }
        public System.Data.Entity.DbSet<Get_Movies.Models.Movie> Movies { get; set; }
        public System.Data.Entity.DbSet<Get_Movies.Models.MoviePlaylist> MoviePlaylists { get; set; }
        public System.Data.Entity.DbSet<Get_Movies.Models.MovieRequest> MovieRequests { get; set; }
        public System.Data.Entity.DbSet<Get_Movies.Models.Playlist> Playlists { get; set; }
        public System.Data.Entity.DbSet<Get_Movies.Models.Premium> Premiums { get; set; }
        public System.Data.Entity.DbSet<Get_Movies.Models.Rating> Ratings { get; set; }
        public System.Data.Entity.DbSet<Get_Movies.Models.User> Users { get; set; }
    }
}