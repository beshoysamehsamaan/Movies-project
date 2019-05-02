using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Get_Movies.Models;

namespace Get_Movies.ViewModels
{
    public class AddMovieToPlaylist
    {
        public List<Playlist> Playlists { get; set; }
        public int? playlistId { get; set; }
        public int? movieId { get; set; }
    }
}