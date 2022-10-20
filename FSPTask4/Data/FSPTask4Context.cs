using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FSPTask4.Models;

namespace FSPTask4.Data
{
    public class FSPTask4Context : DbContext
    {
        public FSPTask4Context (DbContextOptions<FSPTask4Context> options)
            : base(options)
        {
        }

        public DbSet<FSPTask4.Models.Doctor> Doctor { get; set; }

        public DbSet<FSPTask4.Models.Patient> Patient { get; set; }
    }
}
