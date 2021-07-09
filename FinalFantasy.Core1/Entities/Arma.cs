using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core1.Entities
{
    public class Arma
    {
        public string Nome { get; set; }
        public int PuntiDanno { get; set; }
        public ICollection<Personaggio> Personaggi { get; set; } = new List<Personaggio>();

    }
}
