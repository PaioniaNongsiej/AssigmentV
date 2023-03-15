using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_Assignment.Models
{
    public class MoviesContextDB : DbContext
    {
        public MoviesContextDB() : base("name = Movie")
        { 
        }
        public DbSet<Movie> movies { get; set; }
    }
}