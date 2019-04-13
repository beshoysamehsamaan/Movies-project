﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Get_Movies.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Get_Movies.Models
{
    public class ViewLog
    {
        private GetMoviesContext context = GetMoviesContext.GetInstance();

        [Key]
        public int? Id { get; set; }

        [ForeignKey("User")]
        [Index(IsUnique = true)]
        public int? User_Id { get; set; }
        public User User { get; set; }

        [ForeignKey("Movie")]
        public int? Movie_Id { get; set; }
        public Movie Movie { get; set; }

        [Required]
        [MinLength(10)]
        public string Time_Stamp { get; set; }
        //#########################//
        public void Add() { context.ViewLogs.Add(this); context.SaveChanges(); }
        public void Remove(Boolean allRequired, Boolean exactStringMatching) { context.ViewLogs.RemoveRange(this.Search(allRequired, exactStringMatching)); context.SaveChanges(); }
        public IQueryable<ViewLog> Search(Boolean allRequired, Boolean exactStringMatching) { return allRequired ? this.SearchAnd(exactStringMatching) : this.SearchOr(exactStringMatching); }
        private IQueryable<ViewLog> SearchAnd(Boolean exactStringMatching)
        {
            DbSet<ViewLog> entity = context.ViewLogs;
            IQueryable<ViewLog> resultSet = null;
            if (this.Id.HasValue) { resultSet = entity.Where(vl => vl.Id == this.Id); }
            if (this.User_Id.HasValue) { resultSet = entity.Where(vl => vl.User_Id == this.User_Id); }
            if (this.Movie_Id.HasValue) { resultSet = entity.Where(vl => vl.Movie_Id == this.Movie_Id); }
            if (!String.IsNullOrWhiteSpace(this.Time_Stamp)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(vl => vl.Time_Stamp.Equals(this.Time_Stamp))) : ((resultSet ?? entity).Where(vl => vl.Time_Stamp.Contains(this.Time_Stamp))); }
            return resultSet;
        }
        private IQueryable<ViewLog> SearchOr(Boolean exactStringMatching)
        {
            string query = "SELECT * FROM ViewLog WHERE ";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            if (this.Id.HasValue) { query += "Id = @Id OR "; sqlParameters.Add(new SqlParameter("@Id", this.Id)); }
            if (this.User_Id.HasValue) { query += "User_Id = @User_Id OR "; sqlParameters.Add(new SqlParameter("@User_Id", this.User_Id)); }
            if (this.Movie_Id.HasValue) { query += "Movie_Id = @Movie_Id OR "; sqlParameters.Add(new SqlParameter("@Movie_Id", this.Movie_Id)); }
            if (!String.IsNullOrWhiteSpace(this.Time_Stamp)) { query += "Time_Stamp"; query += exactStringMatching ? " = " : " LIKE "; query += "@Time_Stamp OR "; sqlParameters.Add(new SqlParameter("@Time_Stamp", exactStringMatching ? this.Time_Stamp : "%" + this.Time_Stamp + "%")); }
            query = query.Remove(query.Length - 3);
            return sqlParameters.Count() == 0 ? null : context.ViewLogs.SqlQuery(query, sqlParameters.ToArray()).AsQueryable<ViewLog>();
        }
        public void Update(ViewLog newData, Boolean allRequired, Boolean exactStringMatching)
        {
            IQueryable<ViewLog> toUpdateListQueryable = this.Search(allRequired, exactStringMatching);
            Boolean Updatable = this.Id.HasValue || this.User_Id.HasValue || this.Movie_Id.HasValue || !String.IsNullOrWhiteSpace(this.Time_Stamp);
            Boolean Id = newData.Id.HasValue && this.Id != newData.Id;
            Boolean User_Id = newData.User_Id.HasValue && this.User_Id != newData.User_Id;
            Boolean Movie_Id = newData.Movie_Id.HasValue && this.Movie_Id != newData.Movie_Id;
            Boolean Time_Stamp = !String.IsNullOrWhiteSpace(newData.Time_Stamp) && !this.Time_Stamp.Equals(newData.Time_Stamp);
            if (Updatable)
            {
                foreach (var toUpdateRecord in toUpdateListQueryable)
                {
                    if (Id) { toUpdateRecord.Id = newData.Id; }
                    if (User_Id) { toUpdateRecord.User_Id = newData.User_Id; }
                    if (Movie_Id) { toUpdateRecord.Movie_Id = newData.Movie_Id; }
                    if (Time_Stamp) { toUpdateRecord.Time_Stamp = newData.Time_Stamp; }
                }
                context.SaveChanges();
            }
        }
        public List<ViewLog> ListAll() { return context.ViewLogs.ToList<ViewLog>(); }
        //#########################//
    }
}