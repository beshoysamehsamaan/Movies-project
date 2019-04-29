using System;
using System.Collections.Generic;
using System.Data.Entity;
using Get_Movies.Models;
using System.Data;
using System.Linq;
using System.Web;

namespace Get_Movies.Data
{
    public class GetMoviesContext : DbContext
    {
        private static GetMoviesContext Instance = null;
        private GetMoviesContext() : base("GetMoviesDatabase_V28") {}
        public static GetMoviesContext GetInstance() {return Instance??(Instance= new GetMoviesContext());}

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Blacklist> Blacklist { get; set; }
        public DbSet<Casual> Casuals { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MoviePlaylist> MoviePlaylists { get; set; }
        public DbSet<MovieRequest> MovieRequests { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Premium> Premiums { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ViewLog> ViewLogs { get; set; }
    }
}