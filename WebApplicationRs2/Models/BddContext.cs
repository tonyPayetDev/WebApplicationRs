using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationRs2.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Commentaire> Commentaires { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }

    }
}
