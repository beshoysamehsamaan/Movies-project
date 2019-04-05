using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Get_Movies.Data;
using System.Linq;
using System.Web;

namespace Get_Movies.Models
{
    public class Blacklist
    {
        //user_id reason end_date
        //private GetMoviesContext context = GetMoviesContext.GetInstance();

        [Column("id")]
        [Key]
        public int Id { get; set; }

        [Column("user_id")]
        [ForeignKey("User")]
        public int User_Id { get; set; }
        public User User { get; set; }

        [Column("reason")]
        public string Reason { get; set; }

        [Column("end_date")]
        public string End_Date { get; set; }

    }
}