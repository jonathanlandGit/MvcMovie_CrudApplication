using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        //A database context class is needed to coordinate EF Core functionality 
        //(Create, Read, Update, Delete) for the Movie model. The database context
        //is derived from Microsoft.EntityFrameworkCore.DbContext and specifies the
        //entities to include in the data model.
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options) : base(options)
        {
        }

        //creates a DbSet<Movie> property for the entity set. 
        public DbSet<Movie> Movie { get; set; }
    }
}
