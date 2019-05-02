using Get_Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Get_Movies.ViewModels
{
    public class MoviesPagination
    {
        public MoviesPagination() { }
        public int PageNum{get; set;}
        public int PagesCount { get; set; }
        public List<Movie> MoviesList{get; set;}
        public int WholeListCount { get; set; }
    }
}