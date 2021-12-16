using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeDuyHieu702.Models;

namespace MvcMovie.Data
{
    public class LeDuyHieu702Context : DbContext
    {
        public LeDuyHieu702Context(DbContextOptions<LeDuyHieu702Context> options)
            : base(options)
        {
        }
        public DbSet<LeDuyHieu702.Models.UniversityLDH702> UniversityLDH702 { get; set; }

        // public DbSet<LeDuyHieu702Context.Models.University> University { get; set; }
       }
}