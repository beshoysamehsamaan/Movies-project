using Get_Movies.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Get_Movies.Data
{
    public class GetMoviesDatabaseContext : DbContext
    {
        private static GetMoviesDatabaseContext Instance = null;
        public GetMoviesDatabaseContext() : base("_GetMoviesDBv5") { }
        public static GetMoviesDatabaseContext GetInstance() { return Instance ?? (Instance = new GetMoviesDatabaseContext()); }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Blacklist> Blacklist { get; set; }
        public DbSet<Casual> Casuals { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<PlaylistMovie> PlaylistMovies { get; set; }
        public DbSet<MovieRequest> MovieRequests { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Premium> Premiums { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ViewLog> ViewLogs { get; set; }

    }
}