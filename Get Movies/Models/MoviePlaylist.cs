using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ASP.NET.Data;
using System.Linq;
using System.Web;
using ASP.NET.Models;

namespace Get_Movies.Models
{
    public class MoviePlaylist
    {
        //DO NOT PAY ATTENTION FOR THIS MODEL IGONRE IT
        //DO NOT PAY ATTENTION FOR THIS MODEL IGONRE IT
        //DO NOT PAY ATTENTION FOR THIS MODEL IGONRE IT
        //DO NOT PAY ATTENTION FOR THIS MODEL IGONRE IT
        //DO NOT PAY ATTENTION FOR THIS MODEL IGONRE IT
        //DO NOT PAY ATTENTION FOR THIS MODEL IGONRE IT
        //DO NOT PAY ATTENTION FOR THIS MODEL IGONRE IT
        //DO NOT PAY ATTENTION FOR THIS MODEL IGONRE IT
        //DO NOT PAY ATTENTION FOR THIS MODEL IGONRE IT
        //DO NOT PAY ATTENTION FOR THIS MODEL IGONRE IT
        //DO NOT PAY ATTENTION FOR THIS MODEL IGONRE IT
        //DO NOT PAY ATTENTION FOR THIS MODEL IGONRE IT


        //playlist_id movie_id
        private GetMoviesContext context = new GetMoviesContext();

        [Column("playlist_id")]
        public int Playlist_Id { get; set; }
        public Playlist Playlist { get; set; }

        [Column("movie_id")]
        public int Movie_Id { get; set; }
        public Movie Movie { get; set; }
    }
}