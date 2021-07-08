using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core1.Entities
{
    public class Utente
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public ICollection<Hero> Heroes { get; set; } = new List<Hero>();
    }
}
