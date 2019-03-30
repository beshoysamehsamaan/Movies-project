using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NET.Data
{
    public class GetMoviesContext : DbContext
    {
        public GetMoviesContext() : base("GetMovies")
        {

        }

        public System.Data.Entity.DbSet<ASP.NET.Models.User> Users { get; set; }
    }
}