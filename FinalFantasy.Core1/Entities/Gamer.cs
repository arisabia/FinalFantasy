using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core1.Entities
{
    public class Gamer
    {

        public string NickName { get; set; }
        public ICollection<Hero> Heroes { get; set; } = new List<Hero>();

        public override string ToString()
        {
            return $"NockName: {NickName}";
        }
    }
}
