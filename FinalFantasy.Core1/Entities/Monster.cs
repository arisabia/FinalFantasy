using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core1.Entities
{
    public enum TipoMostro
    {
        Ghost,
        Lucifer
    }
    public class Monster : Personaggio
    {
        public TipoMostro TipoMostro { get; set; }

        public override int Fight()
        {
            return Arma.PuntiDanno;
        }

        public override string ToString()
        {
            return $"{Nome} - Liv: {Livello} - PV: {PuntiVita} - {TipoMostro} - Arma: {ArmaNome}";
        }
    }
}
