using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Get_Movies.Data;
using System.Linq;
using System.Web;

namespace Get_Movies.Models
{
    public class MovieRequest
    {
        //id premium_id title note
        //private GetMoviesContext context = GetMoviesContext.GetInstance();

        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("premium_id")]
        [ForeignKey("Premium")]
        public int Premium_Id { get; set; }
        public Premium Premium { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("note")]
        public string Note { get; set; }
    }
}