using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcNiveau.Models
{
    public class MvcNiveauContext : DbContext
    {
        public MvcNiveauContext (DbContextOptions<MvcNiveauContext> options)
            : base(options)
        {
        }

        public DbSet<MvcNiveau.Models.Niveau> Niveau { get; set; }
    }
}