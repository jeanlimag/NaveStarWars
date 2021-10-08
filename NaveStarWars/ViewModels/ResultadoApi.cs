using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaveStarWars.ViewModels
{
    public class ResultadoApi<ViewModel>
    {
        public string Next { get; set; }
        public IReadOnlyList<ViewModel> Results { get; set; }
    }
}
