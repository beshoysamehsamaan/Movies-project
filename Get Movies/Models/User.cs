using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Get_Movies.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Get_Movies.Models
{
    public class User
    {
        private GetMoviesContext context = GetMoviesContext.GetInstance();

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [Index(IsUnique = true)]
        [StringLength(50)]
        public string Email { get; set; }

        [Index(IsUnique = true)]
        [StringLength(50)]
        [MinLength(4)]
        [MaxLength(20)]
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(200)]
        public string Password { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string First_Name { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Last_Name { get; set; }

        [MaxLength(100)]
        public string Profile_Picture { get; set; }

        [Required]
        public int? Verified { get; set; }
        //#########################//
        public void Add(){ context.Users.Add(this); context.SaveChanges();}
        public void Remove(Boolean allRequired,Boolean exactStringMatching) {context.Users.RemoveRange(this.Search(allRequired, exactStringMatching));context.SaveChanges();}
        public IQueryable<User> Search(Boolean allRequired,Boolean exactStringMatching) { return allRequired ? this.SearchAnd(exactStringMatching) : this.SearchOr(exactStringMatching);}
        private IQueryable<User> SearchAnd(Boolean exactStringMatching)
        {
            DbSet<User> entity = context.Users;
            IQueryable<User> resultSet = null;
            if (this.Id.HasValue) { resultSet = entity.Where(u => u.Id == this.Id); }
            if (!String.IsNullOrWhiteSpace(this.Email)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(u => u.Email.Equals(this.Email))) : ((resultSet ?? entity).Where(u => u.Email.Contains(this.Email))); }
            if (!String.IsNullOrWhiteSpace(this.Username)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(u => u.Username.Equals(this.Username))) : ((resultSet ?? entity).Where(u => u.Username.Contains(this.Username))); }
            if (!String.IsNullOrWhiteSpace(this.Password)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(u => u.Password.Equals(this.Password))) : ((resultSet ?? entity).Where(u => u.Password.Contains(this.Password))); }
            if (!String.IsNullOrWhiteSpace(this.First_Name)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(u => u.First_Name.Equals(this.First_Name))) : ((resultSet ?? entity).Where(u => u.First_Name.Contains(this.First_Name))); }
            if (!String.IsNullOrWhiteSpace(this.Last_Name)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(u => u.Last_Name.Equals(this.Last_Name))) : ((resultSet ?? entity).Where(u => u.Last_Name.Contains(this.Last_Name))); }
            if (!String.IsNullOrWhiteSpace(this.Profile_Picture)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(u => u.Profile_Picture.Equals(this.Profile_Picture))) : ((resultSet ?? entity).Where(u => u.Profile_Picture.Contains(this.Profile_Picture))); }
            if (this.Verified.HasValue) { resultSet = ((resultSet ?? entity).Where(u => u.Verified == (this.Verified))); }
            return resultSet;
        }
        private IQueryable<User> SearchOr(Boolean exactStringMatching)
        {
            string query = "SELECT * FROM Users WHERE ";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            if (this.Id.HasValue) { query += "Id = @Id OR "; sqlParameters.Add(new SqlParameter("@Id", this.Id)); }
            if (!String.IsNullOrWhiteSpace(this.Email)) { query += "Email"; query+= exactStringMatching ? " = ":" LIKE ";query += "@Email OR "; sqlParameters.Add(new SqlParameter("@Email", exactStringMatching? this.Email : "%"+ this.Email + "%")); }
            if (!String.IsNullOrWhiteSpace(this.Username)) { query += "Username"; query += exactStringMatching ? " = " : " LIKE "; query += "@Username OR "; sqlParameters.Add(new SqlParameter("@Username", exactStringMatching ? this.Username : "%" + this.Username + "%")); }
            if (!String.IsNullOrWhiteSpace(this.Password)) { query += "Password"; query += exactStringMatching ? " = " : " LIKE "; query += "@Password OR "; sqlParameters.Add(new SqlParameter("@Password", exactStringMatching ? this.Password : "%" + this.Password + "%")); }
            if (!String.IsNullOrWhiteSpace(this.First_Name)) { query += "First_Name"; query += exactStringMatching ? " = " : " LIKE "; query += "@First_Name OR "; sqlParameters.Add(new SqlParameter("@First_Name", exactStringMatching ? this.First_Name : "%" + this.First_Name + "%")); }
            if (!String.IsNullOrWhiteSpace(this.Last_Name)) { query += "Last_Name"; query += exactStringMatching ? " = " : " LIKE "; query += "@Last_Name OR "; sqlParameters.Add(new SqlParameter("@Last_Name", exactStringMatching ? this.Last_Name : "%" + this.Last_Name + "%")); }
            if (!String.IsNullOrWhiteSpace(this.Profile_Picture)) { query += "Profile_Picture"; query += exactStringMatching ? " = " : " LIKE "; query += "@Profile_Picture OR "; sqlParameters.Add(new SqlParameter("@Profile_Picture", exactStringMatching ? this.Profile_Picture : "%" + this.Profile_Picture + "%")); }
            if (this.Verified.HasValue) { query += "Verified = @Verified OR "; sqlParameters.Add(new SqlParameter("@Verified", this.Verified)); }
            query = query.Remove(query.Length - 3);
            return sqlParameters.Count() == 0 ? null : context.Users.SqlQuery(query, sqlParameters.ToArray()).AsQueryable<User>();
        }
        public void Update(User newData,Boolean allRequired, Boolean exactStringMatching)
        {
            IQueryable<User> toUpdateListQueryable = this.Search(allRequired, exactStringMatching);
            Boolean Updatable = this.Id.HasValue || !String.IsNullOrWhiteSpace(this.Email) || !String.IsNullOrWhiteSpace(this.Username) || !String.IsNullOrWhiteSpace(this.Password) || !String.IsNullOrWhiteSpace(this.First_Name) || !String.IsNullOrWhiteSpace(this.Last_Name) || !String.IsNullOrWhiteSpace(this.Profile_Picture) || this.Verified.HasValue;
            Boolean Id = newData.Id .HasValue ;
            Boolean Email =  !String.IsNullOrWhiteSpace(newData.Email) ;
            Boolean Username = !String.IsNullOrWhiteSpace(newData.Username);
            Boolean Password = !String.IsNullOrWhiteSpace(newData.Password) ;
            Boolean First_Name = !String.IsNullOrWhiteSpace(newData.First_Name);
            Boolean Last_Name = !String.IsNullOrWhiteSpace(newData.Last_Name) ;
            Boolean Profile_Picture = !String.IsNullOrWhiteSpace(newData.Profile_Picture) ;
            Boolean Verified = newData.Verified.HasValue ;
            if (Updatable)
            {
                foreach (var toUpdateRecord in toUpdateListQueryable)
                {
                    if (Id) { toUpdateRecord.Id = newData.Id; }
                    if (Email) { toUpdateRecord.Email = newData.Email; }
                    if (Username) { toUpdateRecord.Username = newData.Username; }
                    if (Password) { toUpdateRecord.Password = newData.Password; }
                    if (First_Name) { toUpdateRecord.First_Name = newData.First_Name; }
                    if (Last_Name) { toUpdateRecord.Last_Name = newData.Last_Name; }
                    if (Profile_Picture) { toUpdateRecord.Profile_Picture = newData.Profile_Picture; }
                    if (Verified) { toUpdateRecord.Verified = newData.Verified; }
                }
                context.SaveChanges();
            }
        }
        public List<User> ListAll() { return context.Users.ToList<User>(); }
        //#########################//
        public dynamic GetUserType()
        {
            dynamic result = null;
            if ((result = new Blacklist() { User_Id = this.Id }.Search(true,true).FirstOrDefault<Blacklist>()) != null) { return result; }
            if ((result = new Admin() { User_Id = this.Id }.Search(true, true).FirstOrDefault<Admin>()) != null) { return result; }
            if ((result = new Premium() { User_Id = this.Id }.Search(true, true).FirstOrDefault<Premium>()) != null) { return result; }
            if ((result = new Casual() { User_Id = this.Id }.Search(true, true).FirstOrDefault<Casual>()) != null) { return result; }
            return result;
        }
        public User authenticate(){return this.Search(true,true).FirstOrDefault<User>();}
    }
}