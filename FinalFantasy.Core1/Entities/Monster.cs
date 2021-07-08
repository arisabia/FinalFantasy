using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core1.Entities
{
    public class Monster : Personaggio
    {
        public ICollection<Arma> Armi { get; set; } = new List<Arma>();
    }
}
