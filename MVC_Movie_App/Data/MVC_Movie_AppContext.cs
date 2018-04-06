using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC_Movie_App.Models
{
    public class MVC_Movie_AppContext : DbContext
    {
        public MVC_Movie_AppContext (DbContextOptions<MVC_Movie_AppContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Movie_App.Models.Movie> Movie { get; set; }
    }
}
