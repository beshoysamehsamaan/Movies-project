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
    public class Rating
    {
        //id movie_id rating
        private GetMoviesContext context = new GetMoviesContext();

        [Key, Column("id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("user_id")]
        public int User_Id { get; set; }

        [Column("movie_id")]
        public int Movie_Id { get; set; }
        public Movie Movie { get; set; }

        [Column("rating")]
        public int Rating_ { get; set; }
    }
}