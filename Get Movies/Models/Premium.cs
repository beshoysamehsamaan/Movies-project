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
    public class Premium
    {
        private GetMoviesContext context = GetMoviesContext.GetInstance();

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [Required]
        [ForeignKey("User")]
        [Index(IsUnique = true)]
        public int? User_Id { get; set; }
        public virtual User User { get; set; }
        //#########################//
        public void Add() { context.Premiums.Add(this); context.SaveChanges(); }
        public void Remove(Boolean allRequired, Boolean exactStringMatching) { context.Premiums.RemoveRange(this.Search(allRequired, exactStringMatching)); context.SaveChanges(); }
        public IQueryable<Premium> Search(Boolean allRequired, Boolean exactStringMatching) { return (allRequired ? this.SearchAnd(exactStringMatching) : this.SearchOr(exactStringMatching)) ?? new List<Premium>().AsQueryable(); }
        private IQueryable<Premium> SearchAnd(Boolean exactStringMatching)
        {
            DbSet<Premium> entity = context.Premiums;
            IQueryable<Premium> resultSet = null;
            if (this.Id.HasValue) { resultSet = entity.Where(p => p.Id == this.Id); }
            if (this.User_Id.HasValue) { resultSet = entity.Where(p => p.User_Id == this.User_Id); }
            return resultSet;
        }
        private IQueryable<Premium> SearchOr(Boolean exactStringMatching)
        {
            string query = "SELECT * FROM Premiums WHERE ";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            if (this.Id.HasValue) { query += "Id = @Id OR "; sqlParameters.Add(new SqlParameter("@Id", this.Id)); }
            if (this.User_Id.HasValue) { query += "User_Id = @User_Id OR "; sqlParameters.Add(new SqlParameter("@User_Id", this.User_Id)); }
            query = query.Remove(query.Length - 3);
            return sqlParameters.Count() == 0 ? null : context.Premiums.SqlQuery(query, sqlParameters.ToArray()).AsQueryable<Premium>();
        }
        public void Update(Premium newData, Boolean allRequired, Boolean exactStringMatching)
        {
            IQueryable<Premium> toUpdateListQueryable = this.Search(allRequired, exactStringMatching);
            Boolean Updatable = this.Id.HasValue || this.User_Id.HasValue;
            Boolean Id = newData.Id.HasValue;
            Boolean User_Id = newData.User_Id.HasValue;
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
        public List<Premium> ListAll() { return context.Premiums.ToList<Premium>(); }
        //#########################//
    }
}