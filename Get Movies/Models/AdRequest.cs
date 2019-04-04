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
    public class AdRequest
    {
        //id email note image approved start_date
        private GetMoviesContext context = new GetMoviesContext();

        [Key, Column("id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Index(IsUnique = true), Column("email")]
        public string Email { get; set; }

        [Column("note")]
        public string Note { get; set; }

        [Column("image")]
        public string Image { get; set; }

        [Column("approved")]
        public int Approved { get; set; }

        [Column("start_date")]
        public string Start_Date { get; set; }
    }
}