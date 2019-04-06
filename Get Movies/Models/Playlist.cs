using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Get_Movies.Data;
using System.Linq;
using System.Web;

namespace Get_Movies.Models
{
    public class Playlist
    {
        //id premium_id title movies
        private GetMoviesContext context = GetMoviesContext.GetInstance();

        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("premium_id")]
        [ForeignKey("Premium")]
        public int Premium_Id { get; set; }
        public Premium Premium { get; set; }

        [Column("title")]
        public string Title { get; set; }

        public List<Movie> Movies { get; set; }
        //#########################//
        public void Add()
        {
            context.Playlists.Add(this);
            context.SaveChanges();
        }
        public void Delete()
        {
            Playlist pl = context.Playlists.Find(this.Id);
           
            context.Playlists.Remove(pl);
            context.SaveChanges();
        }

      //  public void Update(int id)
       // {
          //  Playlist pl = context.Playlists.Find(id);
           // pl.
          //  context.SaveChanges();
       // }

        public void AddMovie (int movieid)
        {
            context.MoviePlaylists.Add(new MoviePlaylist() {Playlist_Id= this.Id,Movie_Id=movieid });
            context.SaveChanges();
        }
    }
}