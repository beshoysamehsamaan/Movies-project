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
    public class Casual : GeneralUser
    {
        private GetMoviesDatabaseContext context = GetMoviesDatabaseContext.GetInstance();

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [Required]
        [ForeignKey("User")]
        [Index(IsUnique = true)]
        public int? User_Id { get; set; }
        public virtual User User { get; set; }
        //#########################//
        public void Add() { context.Casuals.Add(this); context.SaveChanges(); }
        public void Remove(Boolean allRequired, Boolean exactStringMatching) { context.Casuals.RemoveRange(this.Search(allRequired, exactStringMatching)); context.SaveChanges(); }
        public IQueryable<Casual> Search(Boolean allRequired, Boolean exactStringMatching) { return (allRequired ? this.SearchAnd(exactStringMatching) : this.SearchOr(exactStringMatching)) ?? new List<Casual>().AsQueryable(); }
        private IQueryable<Casual> SearchAnd(Boolean exactStringMatching)
        {
            DbSet<Casual> entity = context.Casuals;
            IQueryable<Casual> resultSet = null;
            if (this.Id.HasValue) { resultSet = entity.Where(c => c.Id == this.Id); }
            if (this.User_Id.HasValue) { resultSet = entity.Where(c => c.User_Id == this.User_Id); }
            return resultSet;
        }
        private IQueryable<Casual> SearchOr(Boolean exactStringMatching)
        {
            string query = "SELECT * FROM Casuals WHERE ";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            if (this.Id.HasValue) { query += "Id = @Id OR "; sqlParameters.Add(new SqlParameter("@Id", this.Id)); }
            if (this.User_Id.HasValue) { query += "User_Id = @User_Id OR "; sqlParameters.Add(new SqlParameter("@User_Id", this.User_Id)); }
            query = query.Remove(query.Length - 3);
            return sqlParameters.Count() == 0 ? null : context.Casuals.SqlQuery(query, sqlParameters.ToArray()).AsQueryable<Casual>();
        }
        public void Update(Casual newData, Boolean allRequired, Boolean exactStringMatching)
        {
            IQueryable<Casual> toUpdateListQueryable = this.Search(allRequired, exactStringMatching);
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
        public List<Casual> ListAll() { return context.Casuals.ToList<Casual>(); }
        //#########################//
    }
}