using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab26George.Models
{
    public class Lab26GeorgeContext : DbContext
    {
        public Lab26GeorgeContext (DbContextOptions<Lab26GeorgeContext> options)
            : base(options)
        {
        }

        public DbSet<Lab26George.Models.Player> Player { get; set; }
    }
}
