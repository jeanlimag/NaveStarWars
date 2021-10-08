using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaveStarWars.Entidades
{
    public class Nave
    {
        public int IdNave { get; set; }
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public int Passageiros { get; set; }
        public double Carga { get; set; }
        public string Classe { get; set; }

    }
}
