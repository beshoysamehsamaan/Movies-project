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
    public class Rating
    {
        private GetMoviesContext context = GetMoviesContext.GetInstance();

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [ForeignKey("User")]
        public int? User_Id { get; set; }
        public User User { get; set; }

        [ForeignKey("Movie")]
        public int? Movie_Id { get; set; }
        public Movie Movie { get; set; }

        public int? Rating_ { get; set; }
        //#########################//
        public void Add() { context.Ratings.Add(this); context.SaveChanges(); }
        public void Remove(Boolean allRequired, Boolean exactStringMatching) { context.Ratings.RemoveRange(this.Search(allRequired, exactStringMatching)); context.SaveChanges(); }
        public IQueryable<Rating> Search(Boolean allRequired, Boolean exactStringMatching) { return allRequired ? this.SearchAnd(exactStringMatching) : this.SearchOr(exactStringMatching); }
        private IQueryable<Rating> SearchAnd(Boolean exactStringMatching)
        {
            DbSet<Rating> entity = context.Ratings;
            IQueryable<Rating> resultSet = null;
            if (this.Id.HasValue) { resultSet = entity.Where(r => r.Id == this.Id); }
            if (this.User_Id.HasValue) { resultSet = entity.Where(r => r.User_Id == this.User_Id); }
            if (this.Movie_Id.HasValue) { resultSet = entity.Where(r => r.Movie_Id == this.Movie_Id); }
            if (this.Rating_.HasValue) { resultSet = entity.Where(r => r.Rating_ == this.Rating_); }
            return resultSet;
        }
        private IQueryable<Rating> SearchOr(Boolean exactStringMatching)
        {
            string query = "SELECT * FROM Ratings WHERE ";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            if (this.Id.HasValue) { query += "Id = @Id OR "; sqlParameters.Add(new SqlParameter("@Id", this.Id)); }
            if (this.User_Id.HasValue) { query += "User_Id = @User_Id OR "; sqlParameters.Add(new SqlParameter("@User_Id", this.User_Id)); }
            if (this.Movie_Id.HasValue) { query += "Movie_Id = @Movie_Id OR "; sqlParameters.Add(new SqlParameter("@Movie_Id", this.Movie_Id)); }
            if (this.Rating_.HasValue) { query += "Rating_ = @Rating_ OR "; sqlParameters.Add(new SqlParameter("@Rating_", this.Rating_)); }
            query = query.Remove(query.Length - 3);
            return sqlParameters.Count() == 0 ? null : context.Ratings.SqlQuery(query, sqlParameters.ToArray()).AsQueryable<Rating>();
        }
        public void Update(Rating newData, Boolean allRequired, Boolean exactStringMatching)
        {
            IQueryable<Rating> toUpdateListQueryable = this.Search(allRequired, exactStringMatching);
            Boolean Updatable = this.Id.HasValue || this.User_Id.HasValue || this.Movie_Id.HasValue || this.Rating_.HasValue;
            Boolean Id = newData.Id.HasValue && this.Id != newData.Id;
            Boolean User_Id = newData.User_Id.HasValue && this.User_Id != newData.User_Id;
            Boolean Movie_Id = newData.Movie_Id.HasValue && this.Movie_Id != newData.Movie_Id;
            Boolean Rating_ = newData.Rating_.HasValue && this.Rating_ != newData.Rating_;
            if(Updatable)
            {
                foreach (var toUpdateRecord in toUpdateListQueryable)
                {
                    if (Id) { toUpdateRecord.Id = newData.Id; }
                    if (User_Id) { toUpdateRecord.User_Id = newData.User_Id; }
                    if (Movie_Id) { toUpdateRecord.Movie_Id = newData.Movie_Id; }
                    if (Rating_) { toUpdateRecord.Rating_ = newData.Rating_; }
                }
                context.SaveChanges();
            }
        }
        public List<Rating> ListAll() { return context.Ratings.ToList<Rating>(); }
        //#########################//
    }
}