using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Get_Movies.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.SqlClient;
using Get_Movies.ViewModels;
using System.Diagnostics;
using System.IO;

namespace Get_Movies.Models
{
    public class Movie
    {
        private GetMoviesDatabaseContext context = GetMoviesDatabaseContext.GetInstance();

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [Index(IsUnique = true)]
        [MaxLength(100)]
        public string Imdb_Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [ForeignKey("Genre")]
        public int? Genre_Id { get; set; }
        public virtual Genre Genre { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Poster { get; set; }

        public string Youtube_Trailer { get; set; }

        [Required]
        public int? Release_Year { get; set; }

        [Required]
        public DateTime Release_Date { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int? Duration { get; set; }

        [Required]
        public int? Views_Count { get; set; }

        public virtual List<Rating> Ratings { get; set; }

        public virtual List<Playlist> Playlists { get; set; }
        //#########################//
        public void Add()
        {
            string toCopy = AppDomain.CurrentDomain.BaseDirectory + "../Sources/source.mp4";
            string target = AppDomain.CurrentDomain.BaseDirectory + "../Sources/Movies/" + this.Imdb_Id;
            Debug.WriteLine(target);
            if (!Directory.Exists(target)) {
                Directory.CreateDirectory(target);
                File.Copy(toCopy, target + "./source.mp4");
            }
            context.Movies.Add(this); context.SaveChanges();
        }
        public void Remove(Boolean allRequired, Boolean exactStringMatching) { context.Movies.RemoveRange(this.Search(allRequired, exactStringMatching)); context.SaveChanges(); }
        public IQueryable<Movie> Search(Boolean allRequired, Boolean exactStringMatching) { return (allRequired ? this.SearchAnd(exactStringMatching) : this.SearchOr(exactStringMatching)) ?? new List<Movie>().AsQueryable(); }
        private IQueryable<Movie> SearchAnd(Boolean exactStringMatching)
        {
            DbSet<Movie> entity = context.Movies;
            IQueryable<Movie> resultSet = null;
            if (this.Id.HasValue) { resultSet = entity.Where(m => m.Id == this.Id); }
            if (!String.IsNullOrWhiteSpace(this.Imdb_Id)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(m => m.Imdb_Id.Equals(this.Imdb_Id))) : ((resultSet ?? entity).Where(m => m.Imdb_Id.Contains(this.Imdb_Id))); }
            if (this.Genre_Id.HasValue) { resultSet = entity.Where(m => m.Genre_Id == this.Genre_Id); }
            if (!String.IsNullOrWhiteSpace(this.Title)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(m => m.Title.Equals(this.Title))) : ((resultSet ?? entity).Where(m => m.Title.Contains(this.Title))); }
            if (!String.IsNullOrWhiteSpace(this.Director)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(m => m.Director.Equals(this.Director))) : ((resultSet ?? entity).Where(m => m.Director.Contains(this.Director))); }
            if (!String.IsNullOrWhiteSpace(this.Poster)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(m => m.Poster.Equals(this.Poster))) : ((resultSet ?? entity).Where(m => m.Poster.Contains(this.Poster))); }
            if (!String.IsNullOrWhiteSpace(this.Youtube_Trailer)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(m => m.Youtube_Trailer.Equals(this.Youtube_Trailer))) : ((resultSet ?? entity).Where(m => m.Youtube_Trailer.Contains(this.Youtube_Trailer))); }
            if (this.Release_Year.HasValue) { resultSet = entity.Where(m => m.Release_Year == this.Release_Year); }
            if (!String.IsNullOrWhiteSpace(this.Description)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(m => m.Description.Equals(this.Description))) : ((resultSet ?? entity).Where(m => m.Description.Contains(this.Description))); }
            if (this.Duration.HasValue) { resultSet = entity.Where(m => m.Duration == this.Duration); }
            if (this.Views_Count.HasValue) { resultSet = entity.Where(m => m.Views_Count == this.Views_Count); }
            return resultSet;
        }
        private IQueryable<Movie> SearchOr(Boolean exactStringMatching)
        {
            string query = "SELECT * FROM Movies WHERE ";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            if (this.Id.HasValue) { query += "Id = @Id OR "; sqlParameters.Add(new SqlParameter("@Id", this.Id)); }
            if (!String.IsNullOrWhiteSpace(this.Imdb_Id)) { query += "Imdb_Id"; query += exactStringMatching ? " = " : " LIKE "; query += "@Imdb_Id OR "; sqlParameters.Add(new SqlParameter("@Imdb_Id", exactStringMatching ? this.Imdb_Id : "%" + this.Imdb_Id + "%")); }
            if (this.Genre_Id.HasValue) { query += "Genre_Id = @Genre_Id OR "; sqlParameters.Add(new SqlParameter("@Genre_Id", this.Genre_Id)); }
            if (!String.IsNullOrWhiteSpace(this.Director)) { query += "Director"; query += exactStringMatching ? " = " : " LIKE "; query += "@Director OR "; sqlParameters.Add(new SqlParameter("@Director", exactStringMatching ? this.Director : "%" + this.Director + "%")); }
            if (!String.IsNullOrWhiteSpace(this.Title)) { query += "Title"; query += exactStringMatching ? " = " : " LIKE "; query += "@Title OR "; sqlParameters.Add(new SqlParameter("@Title", exactStringMatching ? this.Title : "%" + this.Title + "%")); }
            if (!String.IsNullOrWhiteSpace(this.Poster)) { query += "Poster"; query += exactStringMatching ? " = " : " LIKE "; query += "@Poster OR "; sqlParameters.Add(new SqlParameter("@Poster", exactStringMatching ? this.Poster : "%" + this.Poster + "%")); }
            if (!String.IsNullOrWhiteSpace(this.Youtube_Trailer)) { query += "Youtube_Trailer"; query += exactStringMatching ? " = " : " LIKE "; query += "@Youtube_Trailer OR "; sqlParameters.Add(new SqlParameter("@Youtube_Trailer", exactStringMatching ? this.Youtube_Trailer : "%" + this.Youtube_Trailer + "%")); }
            if (this.Release_Year.HasValue) { query += "Release_Year = @Release_Year OR "; sqlParameters.Add(new SqlParameter("@Release_Year", this.Release_Year)); }
            if (!String.IsNullOrWhiteSpace(this.Description)) { query += "Description"; query += exactStringMatching ? " = " : " LIKE "; query += "@Description OR "; sqlParameters.Add(new SqlParameter("@Description", exactStringMatching ? this.Description : "%" + this.Description + "%")); }
            if (this.Duration.HasValue) { query += "Duration = @Duration OR "; sqlParameters.Add(new SqlParameter("@Duration", this.Duration)); }
            if (this.Views_Count.HasValue) { query += "Views_Count = @Views_Count OR "; sqlParameters.Add(new SqlParameter("@Views_Count", this.Views_Count)); }
            query = query.Remove(query.Length - 3);
            return sqlParameters.Count() == 0 ? null : context.Movies.SqlQuery(query, sqlParameters.ToArray()).AsQueryable<Movie>();
        }
        public void Update(Movie newData, Boolean allRequired, Boolean exactStringMatching)
        {
            IQueryable<Movie> toUpdateListQueryable = this.Search(allRequired, exactStringMatching);
            Boolean Updatable = this.Id.HasValue || !String.IsNullOrWhiteSpace(this.Imdb_Id) || this.Genre_Id.HasValue || !String.IsNullOrWhiteSpace(this.Title) || !String.IsNullOrWhiteSpace(this.Director) || !String.IsNullOrWhiteSpace(this.Poster) || !String.IsNullOrWhiteSpace(this.Youtube_Trailer) || this.Release_Year.HasValue || !String.IsNullOrWhiteSpace(this.Description) || this.Duration.HasValue || this.Views_Count.HasValue;
            Boolean Id = newData.Id.HasValue;
            Boolean Imdb_Id = !String.IsNullOrWhiteSpace(newData.Imdb_Id);
            Boolean Genre_Id = newData.Genre_Id.HasValue;
            Boolean Title = !String.IsNullOrWhiteSpace(newData.Title);
            Boolean Director = !String.IsNullOrWhiteSpace(newData.Director);
            Boolean Poster = !String.IsNullOrWhiteSpace(newData.Poster);
            Boolean Youtube_Trailer = !String.IsNullOrWhiteSpace(newData.Youtube_Trailer);
            Boolean Release_Year = newData.Release_Year.HasValue;
            Boolean Description = !String.IsNullOrWhiteSpace(newData.Description);
            Boolean Duration = newData.Duration.HasValue;
            Boolean Views_Count = newData.Views_Count.HasValue;
            if(Updatable)
            {
                foreach (var toUpdateRecord in toUpdateListQueryable)
                {
                    if (Id) { toUpdateRecord.Id = newData.Id; }
                    if (Imdb_Id) { toUpdateRecord.Imdb_Id = newData.Imdb_Id; }
                    if (Genre_Id) { toUpdateRecord.Genre_Id = newData.Genre_Id; }
                    if (Title) { toUpdateRecord.Title = newData.Title; }
                    if (Director) { toUpdateRecord.Director = newData.Director; }
                    if (Poster) { toUpdateRecord.Poster = newData.Poster; }
                    if (Youtube_Trailer) { toUpdateRecord.Youtube_Trailer = newData.Youtube_Trailer; }
                    if (Release_Year) { toUpdateRecord.Release_Year= newData.Release_Year; }
                    if (Description) { toUpdateRecord.Description = newData.Description; }
                    if (Duration) { toUpdateRecord.Duration = newData.Duration; }
                    if (Views_Count) { toUpdateRecord.Views_Count = newData.Views_Count; }
                }
                context.SaveChanges();
            }
        }
        public List<Movie> ListAll() { return context.Movies.ToList<Movie>(); }
        //#########################//
        public MoviesPagination ListLatest(int offset,int limit)
        { 
            var all = ListAll().OrderByDescending(m=> m.Release_Year);
            return new MoviesPagination(){WholeListCount=all.Count(),MoviesList=all.Skip(offset).Take(limit).ToList()};
        }
        public MoviesPagination SearchMovie(int offset,int limit,string Title, string Director, int? ReleaseYear, int? Genre_Id)
        {

            List<Movie> all = null;
            if (ReleaseYear.HasValue)
            {
                all = (all ?? ListAll()).Where(m => m.Release_Year == ReleaseYear).ToList(); Debug.WriteLine("1");
                if (all != null) { if (Genre_Id.HasValue) { all = all.Where(m => m.Genre_Id == Genre_Id).ToList(); Debug.WriteLine("2"); } }
            }
            else
            {
                if (Genre_Id.HasValue) { all = ListAll().Where(m => m.Genre_Id == Genre_Id).ToList(); Debug.WriteLine("3"); }
            }
            if ((!ReleaseYear.HasValue && !Genre_Id.HasValue) || all!=null)
            {
                if (!String.IsNullOrWhiteSpace(Title) && String.IsNullOrWhiteSpace(Director)) { all = (all??ListAll()).Where(m => m.Title.Contains(Title)).ToList(); Debug.WriteLine("5"); }
                else if (String.IsNullOrWhiteSpace(Title) && !String.IsNullOrWhiteSpace(Director)) { all = (all ?? ListAll()).Where(m => m.Director.Contains(Director)).ToList(); Debug.WriteLine("6"); }
                else if (!String.IsNullOrWhiteSpace(Title) && !String.IsNullOrWhiteSpace(Director)) { all = (all ?? ListAll()).Where(m => m.Title.Contains(Title) || m.Director.Contains(Director)).ToList(); Debug.WriteLine("7"); }
            }
            return new MoviesPagination() { WholeListCount = all.Count(), MoviesList = (all == null ? new Movie().ListAll() : all.Skip(offset).Take(limit).ToList()) };
        }
        public void View(int user_id)
        {
            ViewLog viewLog = new ViewLog() { Movie_Id = this.Id, User_Id = user_id, Time_Stamp = DateTime.Now};
            //new ViewLog() { Movie_Id = this.Id, User_Id = user_id, Time_Stamp = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            viewLog.Add();
            Movie toIncrementViewsCount = context.Movies.Find(this.Id);
            toIncrementViewsCount.Views_Count += 1;
            context.SaveChanges();
        }
        public float CalculateRating()
        {
            int latestRatingCount = Ratings.Count();
            if(latestRatingCount==0)return 5;
            int ratingSum = 0;
            foreach (Rating Rating in Ratings) { ratingSum += Rating.Rating_.GetValueOrDefault();}
            float result = ratingSum / latestRatingCount;
            return (float)result;
            //return (float)Math.Round(result,2);
        }
    }
}