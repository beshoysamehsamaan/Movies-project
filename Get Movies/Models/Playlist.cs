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
    public class Playlist
    {
        private GetMoviesContext context = GetMoviesContext.GetInstance();

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [ForeignKey("Premium")]
        public int? Premium_Id { get; set; }
        public virtual Premium Premium { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Title { get; set; }

        public virtual List<Movie> Movies { get; set; }
        //#########################//
        public void Add() { context.Playlists.Add(this); context.SaveChanges(); }
        public void Remove(Boolean allRequired, Boolean exactStringMatching) { context.Playlists.RemoveRange(this.Search(allRequired, exactStringMatching)); context.SaveChanges(); }
        public IQueryable<Playlist> Search(Boolean allRequired, Boolean exactStringMatching) { return (allRequired ? this.SearchAnd(exactStringMatching) : this.SearchOr(exactStringMatching)) ?? new List<Playlist>().AsQueryable(); }
        private IQueryable<Playlist> SearchAnd(Boolean exactStringMatching)
        {
            DbSet<Playlist> entity = context.Playlists;
            IQueryable<Playlist> resultSet = null;
            if (this.Id.HasValue) { resultSet = entity.Where(pl => pl.Id == this.Id); }
            if (this.Premium_Id.HasValue) { resultSet = entity.Where(pl => pl.Premium_Id == this.Premium_Id); }
            if (!String.IsNullOrWhiteSpace(this.Title)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(pl => pl.Title.Equals(this.Title))) : ((resultSet ?? entity).Where(pl => pl.Title.Contains(this.Title))); }
            return resultSet;
        }
        private IQueryable<Playlist> SearchOr(Boolean exactStringMatching)
        {
            string query = "SELECT * FROM Playlists WHERE ";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            if (this.Id.HasValue) { query += "Id = @Id OR "; sqlParameters.Add(new SqlParameter("@Id", this.Id)); }
            if (this.Premium_Id.HasValue) { query += "Premium_Id = @Premium_Id OR "; sqlParameters.Add(new SqlParameter("@Premium_Id", this.Premium_Id)); }
            if (!String.IsNullOrWhiteSpace(this.Title)) { query += "Title"; query += exactStringMatching ? " = " : " LIKE "; query += "@Title OR "; sqlParameters.Add(new SqlParameter("@Title", exactStringMatching ? this.Title : "%" + this.Title + "%")); }
            query = query.Remove(query.Length - 3);
            return sqlParameters.Count() == 0 ? null : context.Playlists.SqlQuery(query, sqlParameters.ToArray()).AsQueryable<Playlist>();
        }
        public void Update(Playlist newData, Boolean allRequired, Boolean exactStringMatching)
        {
            IQueryable<Playlist> toUpdateListQueryable = this.Search(allRequired, exactStringMatching);
            Boolean Updatable = this.Id.HasValue || this.Premium_Id.HasValue || !String.IsNullOrWhiteSpace(this.Title);
            Boolean Id = newData.Id.HasValue;
            Boolean Premium_Id = newData.Premium_Id.HasValue;
            Boolean Title = !String.IsNullOrWhiteSpace(newData.Title);
            if (Updatable)
            {
                foreach (var toUpdateRecord in toUpdateListQueryable)
                {
                    if (Id) { toUpdateRecord.Id = newData.Id; }
                    if (Premium_Id) { toUpdateRecord.Premium_Id = newData.Premium_Id; }
                    if (Title) { toUpdateRecord.Title = newData.Title; }
                }
                context.SaveChanges();
            }
        }
        public List<Playlist> ListAll() { return context.Playlists.ToList<Playlist>(); }
        //#########################//
        public void AddMovie(Movie movieToAdd)
        {
            new MoviePlaylist() { Playlist_Id = this.Id, Movie_Id = movieToAdd.Id }.Add();
        }
    }
}