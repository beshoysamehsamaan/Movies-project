using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Get_Movies.Data;
using System.Linq;
using System.Web;

namespace Get_Movies.Models
{
    public class MoviePlaylist
    {
        //playlist_id movie_id
        private GetMoviesContext context = GetMoviesContext.GetInstance();

        [Key, Column("id")]
        public int Id { get; set; }

        [Column("playlist_id")]
        [ForeignKey("Playlist")]
        public int Playlist_Id { get; set; }
        public Playlist Playlist { get; set; }

        [Column("movie_id")]
        [ForeignKey("Movie")]
        public int Movie_Id { get; set; }
        public Movie Movie { get; set; }
        //#########################//
        public void Add()
        {
            context.MoviePlaylists.Add(this);
            context.SaveChanges();
        }
    }
}