using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using week8.Models;

namespace week8.Data
{
    public class week8Context : DbContext
    {
        public week8Context (DbContextOptions<week8Context> options)
            : base(options)
        {
        }

        public DbSet<week8.Models.Movie> Movie { get; set; }
    }
}
