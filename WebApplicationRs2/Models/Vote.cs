using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationRs2.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public virtual Commentaire Commentaire { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
    }
}
