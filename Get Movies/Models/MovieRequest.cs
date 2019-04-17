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
    public class MovieRequest
    {
        //id premium_id title note
        private GetMoviesContext context = GetMoviesContext.GetInstance();

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [ForeignKey("Premium")]
        public int? Premium_Id { get; set; }
        public virtual Premium Premium { get; set; }

        [Required]
        public string Title { get; set; }

        public string Note { get; set; }
        //#########################//
        public void Add() { context.MovieRequests.Add(this); context.SaveChanges(); }
        public void Remove(Boolean allRequired, Boolean exactStringMatching) { context.MovieRequests.RemoveRange(this.Search(allRequired, exactStringMatching)); context.SaveChanges(); }
        public IQueryable<MovieRequest> Search(Boolean allRequired, Boolean exactStringMatching) { return (allRequired ? this.SearchAnd(exactStringMatching) : this.SearchOr(exactStringMatching)) ?? new List<MovieRequest>().AsQueryable(); }
        private IQueryable<MovieRequest> SearchAnd(Boolean exactStringMatching)
        {
            DbSet<MovieRequest> entity = context.MovieRequests;
            IQueryable<MovieRequest> resultSet = null;
            if (this.Id.HasValue) { resultSet = entity.Where(mr => mr.Id == this.Id); }
            if (this.Premium_Id.HasValue) { resultSet = entity.Where(mr => mr.Premium_Id == this.Premium_Id); }
            if (!String.IsNullOrWhiteSpace(this.Title)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(mr => mr.Title.Equals(this.Title))) : ((resultSet ?? entity).Where(mr => mr.Title.Contains(this.Title))); }
            if (!String.IsNullOrWhiteSpace(this.Note)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(mr => mr.Note.Equals(this.Note))) : ((resultSet ?? entity).Where(mr => mr.Note.Contains(this.Note))); }
            return resultSet;
        }
        private IQueryable<MovieRequest> SearchOr(Boolean exactStringMatching)
        {
            string query = "SELECT * FROM MovieRequests WHERE ";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            if (this.Id.HasValue) { query += "Id = @Id OR "; sqlParameters.Add(new SqlParameter("@Id", this.Id)); }
            if (this.Premium_Id.HasValue) { query += "Premium_Id = @Premium_Id OR "; sqlParameters.Add(new SqlParameter("@Premium_Id", this.Premium_Id)); }
            if (!String.IsNullOrWhiteSpace(this.Title)) { query += "Title"; query += exactStringMatching ? " = " : " LIKE "; query += "@Title OR "; sqlParameters.Add(new SqlParameter("@Title", exactStringMatching ? this.Title : "%" + this.Title + "%")); }
            if (!String.IsNullOrWhiteSpace(this.Note)) { query += "Note"; query += exactStringMatching ? " = " : " LIKE "; query += "@Note OR "; sqlParameters.Add(new SqlParameter("@Note", exactStringMatching ? this.Note : "%" + this.Note + "%")); }
            query = query.Remove(query.Length - 3);
            return sqlParameters.Count() == 0 ? null : context.MovieRequests.SqlQuery(query, sqlParameters.ToArray()).AsQueryable<MovieRequest>();
        }
        public void Update(MovieRequest newData, Boolean allRequired, Boolean exactStringMatching)
        {
            IQueryable<MovieRequest> toUpdateListQueryable = this.Search(allRequired, exactStringMatching);
            Boolean Updatable = this.Id.HasValue || this.Premium_Id.HasValue || !String.IsNullOrWhiteSpace(this.Title) || !String.IsNullOrWhiteSpace(this.Note);
            Boolean Id = newData.Id.HasValue;
            Boolean Premium_Id = newData.Premium_Id.HasValue;
            Boolean Title = !String.IsNullOrWhiteSpace(newData.Title);
            Boolean Note = !String.IsNullOrWhiteSpace(newData.Note);
            if (Updatable)
            {
                foreach (var toUpdateRecord in toUpdateListQueryable)
                {
                    if (Id) { toUpdateRecord.Id = newData.Id; }
                    if (Premium_Id) { toUpdateRecord.Premium_Id = newData.Premium_Id; }
                    if (Title) { toUpdateRecord.Title = newData.Title; }
                    if (Note) { toUpdateRecord.Note = newData.Note; }
                }
                context.SaveChanges();
            }
        }
        public List<MovieRequest> ListAll() { return context.MovieRequests.ToList<MovieRequest>(); }
        //#########################//
    }
}