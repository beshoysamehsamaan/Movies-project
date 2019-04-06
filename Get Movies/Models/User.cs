using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Get_Movies.Data;
using System.Linq;
using System.Web;

namespace Get_Movies.Models
{
    public class User
    {
        private GetMoviesContext context = GetMoviesContext.GetInstance();

        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{ get; set; }

        [Column("email")]
        [Index(IsUnique = true)]
        [StringLength(50)]
        public string Email { get; set; }

        [Column("username")]
        [Index(IsUnique = true)]
        [StringLength(50)]
        public string Username { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("fname")]
        public string First_Name { get; set; }

        [Column("lname")]
        public string Last_Name { get; set; }

        [Column("profile_picture")]
        public string Profile_Picture { get; set; }

        [Column("verified")]
        public int Verified { get; set; }

        public User() { }
        //#########################//
        public void Add()
        {
            context.Users.Add(this);
            context.SaveChanges();
        }
        public void Remove()
        {
            context.Users.Remove(this);
            context.SaveChanges();
        }
        public User authenticate(String email, String password)
        {
            var query = context.Users.Where(u => u.Email.Equals(email) && u.Password.Equals(password));
            return query.FirstOrDefault<User>();
        }
    }
}