using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Get_Movies.Data;
using System.Linq;
using System.Web;

namespace Get_Movies.Models
{
    public class Admin
    {
        //id user_id
        private GetMoviesContext context = GetMoviesContext.GetInstance();

        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("user_id")]
        [ForeignKey("User")]
        public int User_Id { get; set; }
        public User User { get; set; }
        //#########################//
        public void Add()
        {
            context.Admins.Add(this);
            context.SaveChanges();
        }
    }
}