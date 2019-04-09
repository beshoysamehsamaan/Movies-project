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
    public class AdRequest
    {
        //id email note image approved start_date
        private GetMoviesContext context = GetMoviesContext.GetInstance();

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [Index(IsUnique = true)]
        [StringLength(50)]
        public string Email { get; set; }

        [MaxLength(200)]
        public string Note { get; set; }

        [Required]
        [MaxLength(100)]
        public string Image { get; set; }

        [Required]
        public int? Approved { get; set; }

        [MaxLength(10)]
        [MinLength(10)]
        public string Start_Date { get; set; }
        //#########################//
        public void Add() { context.AdRequests.Add(this); context.SaveChanges(); }
        public void Remove(Boolean allRequired, Boolean exactStringMatching) { context.AdRequests.RemoveRange(this.Search(allRequired, exactStringMatching)); context.SaveChanges(); }
        public IQueryable<AdRequest> Search(Boolean allRequired, Boolean exactStringMatching) { return allRequired ? this.SearchAnd(exactStringMatching) : this.SearchOr(exactStringMatching); }
        private IQueryable<AdRequest> SearchAnd(Boolean exactStringMatching)
        {
            DbSet<AdRequest> entity = context.AdRequests;
            IQueryable<AdRequest> resultSet = null;
            if (this.Id.HasValue) { resultSet = entity.Where(ar => ar.Id == this.Id); }
            if (!String.IsNullOrWhiteSpace(this.Email)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(ar => ar.Email.Equals(this.Email))) : ((resultSet ?? entity).Where(ar => ar.Email.Contains(this.Email))); }
            if (!String.IsNullOrWhiteSpace(this.Note)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(ar => ar.Note.Equals(this.Note))) : ((resultSet ?? entity).Where(ar => ar.Note.Contains(this.Note))); }
            if (!String.IsNullOrWhiteSpace(this.Image)) { resultSet = exactStringMatching ? ((resultSet ?? entity).Where(ar => ar.Image.Equals(this.Image))) : ((resultSet ?? entity).Where(ar => ar.Image.Contains(this.Image))); }
            if (this.Approved.HasValue) { resultSet = ((resultSet ?? entity).Where(ar => ar.Approved == (this.Approved))); }
            return resultSet;
        }
        private IQueryable<AdRequest> SearchOr(Boolean exactStringMatching)
        {
            string query = "SELECT * FROM AdRequests WHERE ";
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            if (this.Id.HasValue) { query += "Id = @Id OR "; sqlParameters.Add(new SqlParameter("@Id", this.Id)); }
            if (!String.IsNullOrWhiteSpace(this.Email)) { query += "Email"; query += exactStringMatching ? " = " : " LIKE "; query += "@Email OR "; sqlParameters.Add(new SqlParameter("@Email", exactStringMatching ? this.Email : "%" + this.Email + "%")); }
            if (!String.IsNullOrWhiteSpace(this.Note)) { query += "Note"; query += exactStringMatching ? " = " : " LIKE "; query += "@Note OR "; sqlParameters.Add(new SqlParameter("@Note", exactStringMatching ? this.Note : "%" + this.Note + "%")); }
            if (!String.IsNullOrWhiteSpace(this.Image)) { query += "Image"; query += exactStringMatching ? " = " : " LIKE "; query += "@Image OR "; sqlParameters.Add(new SqlParameter("@Image", exactStringMatching ? this.Image : "%" + this.Image + "%")); }
            if (this.Approved.HasValue) { query += "Approved = @Approved OR "; sqlParameters.Add(new SqlParameter("@Approved", this.Approved)); }
            query = query.Remove(query.Length - 3);
            return sqlParameters.Count() == 0 ? null : context.AdRequests.SqlQuery(query, sqlParameters.ToArray()).AsQueryable<AdRequest>();
        }
        public void Update(AdRequest newData, Boolean allRequired, Boolean exactStringMatching)
        {
            IQueryable<AdRequest> toUpdateListQueryable = this.Search(allRequired, exactStringMatching);
            Boolean Updatable = this.Id.HasValue || !String.IsNullOrWhiteSpace(this.Email) || !String.IsNullOrWhiteSpace(this.Note) || !String.IsNullOrWhiteSpace(this.Image) || this.Approved.HasValue;
            Boolean Id = newData.Id.HasValue && this.Id != newData.Id;
            Boolean Email = !String.IsNullOrWhiteSpace(newData.Email) && !this.Email.Equals(newData.Email);
            Boolean Note = !String.IsNullOrWhiteSpace(newData.Note) && !this.Note.Equals(newData.Note);
            Boolean Image = !String.IsNullOrWhiteSpace(newData.Image) && !this.Image.Equals(newData.Image);
            Boolean Approved = newData.Approved.HasValue && this.Approved != newData.Approved;
            if(Updatable)
            {
                foreach (var toUpdateRecord in toUpdateListQueryable)
                {
                    if (Id) { toUpdateRecord.Id = newData.Id; }
                    if (Email) { toUpdateRecord.Email = newData.Email; }
                    if (Note) { toUpdateRecord.Note = newData.Note; }
                    if (Image) { toUpdateRecord.Image = newData.Image; }
                    if (Approved) { toUpdateRecord.Approved = newData.Approved; }
                }
                context.SaveChanges();
            }
        }
        public List<AdRequest> ListAll() { return context.AdRequests.ToList<AdRequest>(); }
        //#########################//
    }
}