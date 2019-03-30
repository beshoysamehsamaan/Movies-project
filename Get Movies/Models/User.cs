using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP.NET.Models
{
    public class User
    {

        [Key,Column("id"),DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{ get; set; }

        [Index(IsUnique=true),Column("email")]
        public string Email { get; set; }

        [Index(IsUnique = true),Column("username")]
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

        public Boolean authenticate(String email,String password)
        {
            using (var context = new Data.GetMoviesContext())
            {
                var query = context.Users.Where(u => u.Email == email).Where(u => u.Password == password);
                return (query.FirstOrDefault<User>()!=null);
            }
        }
        public void AddUser(String email,String username, String password, String first_name, String last_name, String profile_picture, int verified)
        {
            var context = new Data.GetMoviesContext();
            User toAdd = new User()
            {
                Email = email,
                Username = username,
                Password = password,
                First_Name = first_name,
                Last_Name = last_name,
                Profile_Picture = profile_picture,
                Verified = verified
            };
            context.Users.Add(toAdd);
            context.SaveChanges();
        }
    }
}