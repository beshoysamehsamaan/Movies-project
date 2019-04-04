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
    public class Blacklist
    {
        //user_id reason end_date
        private GetMoviesContext context = new GetMoviesContext();

        [Column("user_id")]
        public int User_Id { get; set; }
        public User User { get; set; }
      
        [Column("reason")]
        public string Reason { get; set; }

        [Column("end_date")]
        public string End_Date { get; set; }

    }
}