using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Get_Movies.Data;
using System.Linq;
using System.Web;

namespace Get_Movies.Models
{
    public class AdRequest
    {
        //id email note image approved start_date
        //private GetMoviesContext context = GetMoviesContext.GetInstance();

        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("email")]
        [Index(IsUnique = true)]
        [StringLength(50)]
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