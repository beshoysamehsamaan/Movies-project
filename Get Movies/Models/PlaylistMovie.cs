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
    public class PlaylistMovie
    {
        private GetMoviesDatabaseContext context = GetMoviesDatabaseContext.GetInstance();

        [Key]
        public int? Id { get; set; }

        [Required]
        [ForeignKey("Playlist")]
        public int? Playlist_Id { get; set; }
        public virtual Playlist Playlist { get; set; }

        [Required]
        [ForeignKey("Movie")]
        public int? Movie_Id { get; set; }
        public virtual Movie Movie { get; set; }
        //#########################//
        public void Add() { context.MoviePlaylists.Add(this); context.SaveChanges(); }
        public void Remove(Boolean allRequired, Boolean exactStringMatching) { context.MoviePlaylists.RemoveRange(this.Search(allRequired, exactStringMatching)); context.SaveChanges(); }
        public IQueryable<PlaylistMovie> Search(Boolean allRequired, Boolean exactStringMatching) { return (allRequired ? this.SearchAnd(exactStringMatching) : this.SearchOr(exactStringMatching)) ?? new List<PlaylistMovie>().AsQueryable(); }
        private IQueryable<PlaylistMovie> SearchAnd(Boolean exactStringMatching)
        {
            DbSet<PlaylistMovie> entity = context.MoviePlaylists;
            IQueryable<PlaylistMovie> resultSet = null;
            if (this.Id.HasValue) { resultSet = entity.Where(mp => mp.Id == this.Id); }
            if (this.Playlist_Id.HasValue) { resultSet = entity.Where(mp => mp.Playlist_Id == this.Playlist_Id); }
            if (this.Movie_Id.HasValue) { resultSet = entity.Where(mp => mp.Movie_Id == this.Movie_Id); }
            return resultSet;
        }
        private IQueryable<PlaylistMovie> SearchOr(Boolean exactStringMatching)
        {
            string query = "SELECT * FROM MoviePlaylists WHERE ";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            if (this.Id.HasValue) { query += "Id = @Id OR "; sqlParameters.Add(new SqlParameter("@Id", this.Id)); }
            if (this.Playlist_Id.HasValue) { query += "Playlist_Id = @Playlist_Id OR "; sqlParameters.Add(new SqlParameter("@Playlist_Id", this.Playlist_Id)); }
            if (this.Movie_Id.HasValue) { query += "Movie_Id = @Movie_Id OR "; sqlParameters.Add(new SqlParameter("@Movie_Id", this.Movie_Id)); }
            query = query.Remove(query.Length - 3);
            return sqlParameters.Count() == 0 ? null : context.MoviePlaylists.SqlQuery(query, sqlParameters.ToArray()).AsQueryable<PlaylistMovie>();
        }
        public void Update(PlaylistMovie newData, Boolean allRequired, Boolean exactStringMatching)
        {
            IQueryable<PlaylistMovie> toUpdateListQueryable = this.Search(allRequired, exactStringMatching);
            Boolean Updatable = this.Id.HasValue || this.Playlist_Id.HasValue || this.Movie_Id.HasValue;
            Boolean Id = newData.Id.HasValue;
            Boolean Playlist_Id = newData.Playlist_Id.HasValue;
            Boolean Movie_Id = newData.Movie_Id.HasValue;
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
        public List<PlaylistMovie> ListAll() { return context.MoviePlaylists.ToList<PlaylistMovie>(); }
        //#########################/
    }
}