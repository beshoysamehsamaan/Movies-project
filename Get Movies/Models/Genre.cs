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
    public class Genre
    {
        private GetMoviesContext context = GetMoviesContext.GetInstance();

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [Required]
        public string Genre_ { get; set; }
        public virtual List<Movie> Movies { get; set; }
        //#########################//
        public void Add() { context.Genres.Add(this); context.SaveChanges(); }
        public void Remove(Boolean allRequired, Boolean exactStringMatching) { context.Genres.RemoveRange(this.Search(allRequired, exactStringMatching)); context.SaveChanges(); }
        public IQueryable<Genre> Search(Boolean allRequired, Boolean exactStringMatching) { return (allRequired ? this.SearchAnd(exactStringMatching) : this.SearchOr(exactStringMatching)) ?? new List<Genre>().AsQueryable(); }
        private IQueryable<Genre> SearchAnd(Boolean exactStringMatching)
        {
            DbSet<Genre> entity = context.Genres;
            IQueryable<Genre> resultSet = null;
            if (this.Id.HasValue) { resultSet = entity.Where(g => g.Id == this.Id); }
            if (!String.IsNullOrWhiteSpace(this.Genre_)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(g => g.Genre_.Equals(this.Genre_))) : ((resultSet ?? entity).Where(g => g.Genre_.Contains(this.Genre_))); }
            return resultSet;
        }
        private IQueryable<Genre> SearchOr(Boolean exactStringMatching)
        {
            string query = "SELECT * FROM Genres WHERE ";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            if (this.Id.HasValue) { query += "Id = @Id OR "; sqlParameters.Add(new SqlParameter("@Id", this.Id)); }
            if (!String.IsNullOrWhiteSpace(this.Genre_)) { query += "Genre_"; query += exactStringMatching ? " = " : " LIKE "; query += "@Genre_ OR "; sqlParameters.Add(new SqlParameter("@Genre_", exactStringMatching ? this.Genre_ : "%" + this.Genre_ + "%")); }
            query = query.Remove(query.Length - 3);
            return sqlParameters.Count() == 0 ? null : context.Genres.SqlQuery(query, sqlParameters.ToArray()).AsQueryable<Genre>();
        }
        public void Update(Genre newData, Boolean allRequired, Boolean exactStringMatching)
        {
            IQueryable<Genre> toUpdateListQueryable = this.Search(allRequired, exactStringMatching);
            Boolean Updatable = this.Id.HasValue || !String.IsNullOrWhiteSpace(this.Genre_);
            Boolean Id = newData.Id.HasValue;
            Boolean Reason = !String.IsNullOrWhiteSpace(newData.Genre_);
            if (Updatable)
            {
                foreach (var toUpdateRecord in toUpdateListQueryable)
                {
                    if (Id) { toUpdateRecord.Id = newData.Id; }
                    if (Reason) { toUpdateRecord.Genre_ = newData.Genre_; }
                }
                context.SaveChanges();
            }
        }
        public List<Genre> ListAll() { return context.Genres.ToList<Genre>(); }
        //#########################//
    }
}