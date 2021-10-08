using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaveStarWars.Entidades
{
   public class Planeta
    {
        public int IdPlaneta { get; set; }
        public string Nome { get; set; }
        public double Rotacao { get; set; }
        public double Orbita { get; set; }
        public double Diametro { get; set; }
        public string Clima { get; set; }
        public int Populacao { get; set; }
    }
}
