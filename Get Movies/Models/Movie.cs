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
    public class Movie
    {
        private GetMoviesContext context = GetMoviesContext.GetInstance();

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [ForeignKey("Genre")]
        public int? Genre_Id { get; set; }
        public Genre Genre { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Poster { get; set; }

        [Required]
        [StringLength(50)]
        [MinLength(10)]
        [MaxLength(10)]
        public string Release_Date { get; set; }

        [Required]
        [MaxLength(10)]
        public string Description { get; set; }

        [Required]
        public int? Duration { get; set; }

        [Required]
        public int? View_Count { get; set; }

        [Required]
        public int? Rating_Count { get; set; }

        public List<Playlist> Playlists { get; set; }
        //#########################//
        public void Add() { context.Movies.Add(this); context.SaveChanges(); }
        public void Remove(Boolean allRequired, Boolean exactStringMatching) { context.Movies.RemoveRange(this.Search(allRequired, exactStringMatching)); context.SaveChanges(); }
        public IQueryable<Movie> Search(Boolean allRequired, Boolean exactStringMatching) { return allRequired ? this.SearchAnd(exactStringMatching) : this.SearchOr(exactStringMatching); }
        private IQueryable<Movie> SearchAnd(Boolean exactStringMatching)
        {
            DbSet<Movie> entity = context.Movies;
            IQueryable<Movie> resultSet = null;
            if (this.Id.HasValue) { resultSet = entity.Where(m => m.Id == this.Id); }
            if (this.Genre_Id.HasValue) { resultSet = entity.Where(m => m.Genre_Id == this.Genre_Id); }
            if (!String.IsNullOrWhiteSpace(this.Director)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(m => m.Director.Equals(this.Director))) : ((resultSet ?? entity).Where(m => m.Director.Contains(this.Director))); }
            if (!String.IsNullOrWhiteSpace(this.Poster)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(m => m.Poster.Equals(this.Poster))) : ((resultSet ?? entity).Where(m => m.Poster.Contains(this.Poster))); }
            if (!String.IsNullOrWhiteSpace(this.Release_Date)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(m => m.Release_Date.Equals(this.Release_Date))) : ((resultSet ?? entity).Where(m => m.Release_Date.Contains(this.Release_Date))); }
            if (!String.IsNullOrWhiteSpace(this.Description)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(m => m.Description.Equals(this.Description))) : ((resultSet ?? entity).Where(m => m.Description.Contains(this.Description))); }
            if (this.Duration.HasValue) { resultSet = entity.Where(m => m.Duration == this.Duration); }
            if (this.View_Count.HasValue) { resultSet = entity.Where(m => m.View_Count == this.View_Count); }
            if (this.Rating_Count.HasValue) { resultSet = entity.Where(m => m.Rating_Count == this.Rating_Count); }
            return resultSet;
        }
        private IQueryable<Movie> SearchOr(Boolean exactStringMatching)
        {
            string query = "SELECT * FROM Movies WHERE ";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            if (this.Id.HasValue) { query += "Id = @Id OR "; sqlParameters.Add(new SqlParameter("@Id", this.Id)); }
            if (this.Genre_Id.HasValue) { query += "Genre_Id = @Genre_Id OR "; sqlParameters.Add(new SqlParameter("@Genre_Id", this.Genre_Id)); }
            if (!String.IsNullOrWhiteSpace(this.Director)) { query += "Director"; query += exactStringMatching ? " = " : " LIKE "; query += "@Director OR "; sqlParameters.Add(new SqlParameter("@Director", exactStringMatching ? this.Director : "%" + this.Director + "%")); }
            if (!String.IsNullOrWhiteSpace(this.Poster)) { query += "Poster"; query += exactStringMatching ? " = " : " LIKE "; query += "@Poster OR "; sqlParameters.Add(new SqlParameter("@Poster", exactStringMatching ? this.Poster : "%" + this.Poster + "%")); }
            if (!String.IsNullOrWhiteSpace(this.Release_Date)) { query += "Release_Date"; query += exactStringMatching ? " = " : " LIKE "; query += "@Release_Date OR "; sqlParameters.Add(new SqlParameter("@Release_Date", exactStringMatching ? this.Release_Date : "%" + this.Release_Date + "%")); }
            if (!String.IsNullOrWhiteSpace(this.Description)) { query += "Description"; query += exactStringMatching ? " = " : " LIKE "; query += "@Description OR "; sqlParameters.Add(new SqlParameter("@Description", exactStringMatching ? this.Description : "%" + this.Description + "%")); }
            if (this.Duration.HasValue) { query += "Duration = @Duration OR "; sqlParameters.Add(new SqlParameter("@Duration", this.Duration)); }
            if (this.View_Count.HasValue) { query += "View_Count = @View_Count OR "; sqlParameters.Add(new SqlParameter("@View_Count", this.View_Count)); }
            if (this.Rating_Count.HasValue) { query += "Rating_Count = @Rating_Count OR "; sqlParameters.Add(new SqlParameter("@Rating_Count", this.Rating_Count)); }
            query = query.Remove(query.Length - 3);
            return sqlParameters.Count() == 0 ? null : context.Movies.SqlQuery(query, sqlParameters.ToArray()).AsQueryable<Movie>();
        }
        public void Update(Movie newData, Boolean allRequired, Boolean exactStringMatching)
        {
            IQueryable<Movie> toUpdateListQueryable = this.Search(allRequired, exactStringMatching);
            Boolean Updatable = this.Id.HasValue || this.Genre_Id.HasValue || !String.IsNullOrWhiteSpace(this.Director) || !String.IsNullOrWhiteSpace(this.Poster) || !String.IsNullOrWhiteSpace(this.Release_Date) || !String.IsNullOrWhiteSpace(this.Description) || this.Duration.HasValue || this.View_Count.HasValue || this.Rating_Count.HasValue;
            Boolean Id = newData.Id.HasValue && this.Id != newData.Id;
            Boolean Genre_Id = newData.Genre_Id.HasValue && this.Genre_Id != newData.Genre_Id;
            Boolean Director = !String.IsNullOrWhiteSpace(newData.Director) && !this.Director.Equals(newData.Director);
            Boolean Poster = !String.IsNullOrWhiteSpace(newData.Poster) && !this.Poster.Equals(newData.Poster);
            Boolean Release_Date = !String.IsNullOrWhiteSpace(newData.Release_Date) && !this.Release_Date.Equals(newData.Release_Date);
            Boolean Description = !String.IsNullOrWhiteSpace(newData.Description) && !this.Release_Date.Equals(newData.Description);
            Boolean Duration = newData.Duration.HasValue && this.Duration != newData.Duration;
            Boolean View_Count = newData.View_Count.HasValue && this.View_Count != newData.View_Count;
            Boolean Rating_Count = newData.Rating_Count.HasValue && this.Rating_Count != newData.Rating_Count;
            if(Updatable)
            {
                foreach (var toUpdateRecord in toUpdateListQueryable)
                {
                    if (Id) { toUpdateRecord.Id = newData.Id; }
                    if (Genre_Id) { toUpdateRecord.Genre_Id = newData.Genre_Id; }
                    if (Director) { toUpdateRecord.Director = newData.Director; }
                    if (Poster) { toUpdateRecord.Poster = newData.Poster; }
                    if (Release_Date) { toUpdateRecord.Release_Date = newData.Release_Date; }
                    if (Description) { toUpdateRecord.Description = newData.Description; }
                    if (View_Count) { toUpdateRecord.View_Count = newData.View_Count; }
                    if (Rating_Count) { toUpdateRecord.Rating_Count = newData.Rating_Count; }
                }
                context.SaveChanges();
            }
        }
        public List<Movie> ListAll() { return context.Movies.ToList<Movie>(); }
        //#########################//
        public void Rate(int rater_id,int rating)
        {
            new Rating() { Movie_Id = this.Id, User_Id = rater_id, Rating_ = rating }.Add();
            int? latestRatingCount = this.Search(true, true).FirstOrDefault<Movie>().Rating_Count;
            this.Update(new Movie() { Rating_Count= latestRatingCount + 1 },true,true);
        }
    }
}