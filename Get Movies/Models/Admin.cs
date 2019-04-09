using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Get_Movies.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Get_Movies.Models
{
    public class Admin
    {
        private GetMoviesContext context = GetMoviesContext.GetInstance();

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [ForeignKey("User")]
        [Index(IsUnique = true)]
        public int? User_Id { get; set; }
        public User User { get; set; }
        //#########################//
        public void Add() { context.Admins.Add(this); context.SaveChanges(); }
        public void Remove(Boolean allRequired, Boolean exactStringMatching) { context.Admins.RemoveRange(this.Search(allRequired, exactStringMatching)); context.SaveChanges(); }
        public IQueryable<Admin> Search(Boolean allRequired, Boolean exactStringMatching) { return allRequired ? this.SearchAnd(exactStringMatching) : this.SearchOr(exactStringMatching); }
        private IQueryable<Admin> SearchAnd(Boolean exactStringMatching)
        {
            DbSet<Admin> entity = context.Admins;
            IQueryable<Admin> resultSet = null;
            if (this.Id.HasValue) { resultSet = entity.Where(a => a.Id == this.Id); }
            if (this.User_Id.HasValue) { resultSet = entity.Where(a => a.User_Id == this.User_Id); }
            return resultSet;
        }
        private IQueryable<Admin> SearchOr(Boolean exactStringMatching)
        {
            string query = "SELECT * FROM Admins WHERE ";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            if (this.Id.HasValue) { query += "Id = @Id OR "; sqlParameters.Add(new SqlParameter("@Id", this.Id)); }
            if (this.User_Id.HasValue) { query += "User_Id = @User_Id OR "; sqlParameters.Add(new SqlParameter("@User_Id", this.User_Id)); }
            query = query.Remove(query.Length - 3);
            return sqlParameters.Count() == 0 ? null : context.Admins.SqlQuery(query, sqlParameters.ToArray()).AsQueryable<Admin>();
        }
        public void Update(Admin newData, Boolean allRequired, Boolean exactStringMatching)
        {
            IQueryable<Admin> toUpdateListQueryable = this.Search(allRequired, exactStringMatching);
            Boolean Updatable = this.Id.HasValue || this.User_Id.HasValue;
            Boolean Id = newData.Id.HasValue && this.Id != newData.Id;
            Boolean User_Id = newData.User_Id.HasValue && this.User_Id != newData.User_Id;
            if (Updatable)
            {
                foreach (var toUpdateRecord in toUpdateListQueryable)
                {
                    if (Id) { toUpdateRecord.Id = newData.Id; }
                    if (User_Id) { toUpdateRecord.User_Id = newData.User_Id; }
                }
                context.SaveChanges();
            }
        }
        public List<Admin> ListAll() { return context.Admins.ToList<Admin>(); }
        //#########################//
    }
}