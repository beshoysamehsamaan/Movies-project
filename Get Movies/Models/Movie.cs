using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Get_Movies.Data;
using System.Linq;
using System.Web;

namespace Get_Movies.Models
{
    public class Movie
    {
        //id title genre director poster release_date view_count
        private GetMoviesContext context = GetMoviesContext.GetInstance();

        [Key, Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("genre")]
        public string Genre { get; set; }

        [Column("director")]
        public string Director { get; set; }

        [Column("poster")]
        public string Poster { get; set; }

        [Column("release_date")]
        public string Release_date { get; set; }

        [Column("view_count")]
        public int View_Count { get; set; }

        [Column("rating_count")]
        public int Rating_Count { get; set; }

        public List<Playlist> Playlists { get; set; }
        //#########################//
        public void Add()
        {
            context.Movies.Add(this);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Movie a1 = context.Movies.Find(id);
            context.Movies.Remove(a1);
            context.SaveChanges();
        }

    }
}