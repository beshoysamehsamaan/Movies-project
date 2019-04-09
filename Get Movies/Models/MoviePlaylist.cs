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
    public class MoviePlaylist
    {
        private GetMoviesContext context = GetMoviesContext.GetInstance();

        [Key]
        public int? Id { get; set; }

        [ForeignKey("Playlist")]
        public int? Playlist_Id { get; set; }
        public Playlist Playlist { get; set; }

        [ForeignKey("Movie")]
        public int? Movie_Id { get; set; }
        public Movie Movie { get; set; }
        //#########################//
        public void Add() { context.MoviePlaylists.Add(this); context.SaveChanges(); }
        public void Remove(Boolean allRequired, Boolean exactStringMatching) { context.MoviePlaylists.RemoveRange(this.Search(allRequired, exactStringMatching)); context.SaveChanges(); }
        public IQueryable<MoviePlaylist> Search(Boolean allRequired, Boolean exactStringMatching) { return allRequired ? this.SearchAnd(exactStringMatching) : this.SearchOr(exactStringMatching); }
        private IQueryable<MoviePlaylist> SearchAnd(Boolean exactStringMatching)
        {
            DbSet<MoviePlaylist> entity = context.MoviePlaylists;
            IQueryable<MoviePlaylist> resultSet = null;
            if (this.Id.HasValue) { resultSet = entity.Where(mp => mp.Id == this.Id); }
            if (this.Playlist_Id.HasValue) { resultSet = entity.Where(mp => mp.Playlist_Id == this.Playlist_Id); }
            if (this.Movie_Id.HasValue) { resultSet = entity.Where(mp => mp.Movie_Id == this.Movie_Id); }
            return resultSet;
        }
        private IQueryable<MoviePlaylist> SearchOr(Boolean exactStringMatching)
        {
            string query = "SELECT * FROM MoviePlaylists WHERE ";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            if (this.Id.HasValue) { query += "Id = @Id OR "; sqlParameters.Add(new SqlParameter("@Id", this.Id)); }
            if (this.Playlist_Id.HasValue) { query += "Playlist_Id = @Playlist_Id OR "; sqlParameters.Add(new SqlParameter("@Playlist_Id", this.Playlist_Id)); }
            if (this.Movie_Id.HasValue) { query += "Movie_Id = @Movie_Id OR "; sqlParameters.Add(new SqlParameter("@Movie_Id", this.Movie_Id)); }
            query = query.Remove(query.Length - 3);
            return sqlParameters.Count() == 0 ? null : context.MoviePlaylists.SqlQuery(query, sqlParameters.ToArray()).AsQueryable<MoviePlaylist>();
        }
        public void Update(MoviePlaylist newData, Boolean allRequired, Boolean exactStringMatching)
        {
            IQueryable<MoviePlaylist> toUpdateListQueryable = this.Search(allRequired, exactStringMatching);
            Boolean Updatable = this.Id.HasValue || this.Playlist_Id.HasValue || this.Movie_Id.HasValue;
            Boolean Id = newData.Id.HasValue && this.Id != newData.Id;
            Boolean Playlist_Id = newData.Playlist_Id.HasValue && this.Playlist_Id != newData.Playlist_Id;
            Boolean Movie_Id = newData.Movie_Id.HasValue && this.Movie_Id != newData.Movie_Id;
            if (Updatable)
            {
                foreach (var toUpdateRecord in toUpdateListQueryable)
                {
                    if (Id) { toUpdateRecord.Id = newData.Id; }
                    if (Playlist_Id) { toUpdateRecord.Playlist_Id = newData.Playlist_Id; }
                    if (Movie_Id) { toUpdateRecord.Movie_Id = newData.Movie_Id; }
                }
                context.SaveChanges();
            }
        }
        public List<MoviePlaylist> ListAll() { return context.MoviePlaylists.ToList<MoviePlaylist>(); }
        //#########################//
    }
}