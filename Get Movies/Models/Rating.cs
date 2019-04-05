using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Get_Movies.Data;
using System.Linq;
using System.Web;

namespace Get_Movies.Models
{
    public class Rating
    {
        //id user_id movie_id rating
        //private GetMoviesContext context = GetMoviesContext.GetInstance();

        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("user_id")]
        [ForeignKey("User")]
        public int User_Id { get; set; }
        public User User { get; set; }

        [Column("movie_id")]
        [ForeignKey("Movie")]
        public int Movie_Id { get; set; }
        public Movie Movie { get; set; }

        [Column("rating")]
        public int Rating_ { get; set; }
    }
}