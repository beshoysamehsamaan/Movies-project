using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Get_Movies.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.SqlClient;
using Get_Movies.ViewModels;

namespace Get_Movies.Models
{
    public class Blacklist : GeneralUser
    {
        private GetMoviesDatabaseContext context = GetMoviesDatabaseContext.GetInstance();

        [Key]
        public int? Id { get; set; }

        [Required]
        [ForeignKey("User")]
        [Index(IsUnique = true)]
        public int? User_Id { get; set; }
        public virtual User User { get; set; }

        [MaxLength(50)]
        public string Reason { get; set; }

        [Required]
        [StringLength(50)]
        [MaxLength(10)]
        [MinLength(10)]
        public string End_Date { get; set; }
        //#########################//
        public void Add() { context.Blacklist.Add(this); context.SaveChanges(); }
        public void Remove(Boolean allRequired, Boolean exactStringMatching) { context.Blacklist.RemoveRange(this.Search(allRequired, exactStringMatching)); context.SaveChanges(); }
        public IQueryable<Blacklist> Search(Boolean allRequired, Boolean exactStringMatching) { return (allRequired ? this.SearchAnd(exactStringMatching) : this.SearchOr(exactStringMatching)) ?? new List<Blacklist>().AsQueryable(); }
        private IQueryable<Blacklist> SearchAnd(Boolean exactStringMatching)
        {
            DbSet<Blacklist> entity = context.Blacklist;
            IQueryable<Blacklist> resultSet = null;
            if (this.Id.HasValue) { resultSet = entity.Where(bl => bl.Id == this.Id); }
            if (this.User_Id.HasValue) { resultSet = entity.Where(bl => bl.User_Id == this.User_Id); }
            if (!String.IsNullOrWhiteSpace(this.Reason)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(bl => bl.Reason.Equals(this.Reason))) : ((resultSet ?? entity).Where(bl => bl.Reason.Contains(this.Reason))); }
            return resultSet;
        }
        private IQueryable<Blacklist> SearchOr(Boolean exactStringMatching)
        {
            string query = "SELECT * FROM Blacklist WHERE ";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            if (this.Id.HasValue) { query += "Id = @Id OR "; sqlParameters.Add(new SqlParameter("@Id", this.Id)); }
            if (this.User_Id.HasValue) { query += "User_Id = @User_Id OR "; sqlParameters.Add(new SqlParameter("@User_Id", this.User_Id)); }
            if (!String.IsNullOrWhiteSpace(this.Reason)) { query += "Reason"; query += exactStringMatching ? " = " : " LIKE "; query += "@Reason OR "; sqlParameters.Add(new SqlParameter("@Reason", exactStringMatching ? this.Reason : "%" + this.Reason + "%")); }
            query = query.Remove(query.Length - 3);
            return sqlParameters.Count() == 0 ? null : context.Blacklist.SqlQuery(query, sqlParameters.ToArray()).AsQueryable<Blacklist>();
        }
        public void Update(Blacklist newData, Boolean allRequired, Boolean exactStringMatching)
        {
            IQueryable<Blacklist> toUpdateListQueryable = this.Search(allRequired, exactStringMatching);
            Boolean Updatable = this.Id.HasValue || this.User_Id.HasValue || !String.IsNullOrWhiteSpace(this.Reason);
            Boolean Id = newData.Id.HasValue;
            Boolean User_Id = newData.User_Id.HasValue;
            Boolean Reason = !String.IsNullOrWhiteSpace(newData.Reason);
            if(Updatable)
            {
                foreach (var toUpdateRecord in toUpdateListQueryable)
                {
                    if (Id) { toUpdateRecord.Id = newData.Id; }
                    if (User_Id) { toUpdateRecord.User_Id = newData.User_Id; }
                    if (Reason) { toUpdateRecord.Reason = newData.Reason; }
                }
                context.SaveChanges();
            }
        }
        public List<Blacklist> ListAll() { return context.Blacklist.ToList<Blacklist>(); }
        //#########################//
    }
}