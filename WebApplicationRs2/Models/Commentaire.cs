using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationRs2.Models
{
    public class Commentaire
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int nbJaime { get; set; }
        public int createByUser { get; set; }

        public DateTime Date { get; set; }
    }
}
