using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaveStarWars.Entidades
{
   public  class Piloto
    {
        public int IdPiloto { get; set; }
        public string Nome { get; set; }
        public string AnoNascimento { get; set; }
        public int IdPlaneta { get; set; }

        // Relacionamentos 
        public Planeta Planeta { get; set; }
        public List<Nave> Naves { get; set; }
    }
}
