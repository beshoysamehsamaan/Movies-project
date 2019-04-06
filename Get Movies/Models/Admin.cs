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
        
        //public void Update(int id)
        //{
        //    Admin a1 = context.Admins.Find(id);
            
        //    context.SaveChanges();
        //}

        public void Delete(int id)
        {
            Admin a1 = context.Admins.Find(id);
            context.Admins.Remove(a1);
            context.SaveChanges();
        }

        public List<Movie> List()
        {
            return context.Movies.ToList<Movie>();
        }



    }
}