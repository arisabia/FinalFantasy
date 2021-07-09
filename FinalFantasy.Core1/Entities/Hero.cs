using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core1.Entities
{
    public enum TipoEroe
    {
        Soldier,
        Wizard
    }
    public class Hero : Personaggio
    {
        public TipoEroe TipoEroe { get; set; }
        public int PuntiLivello { get; set; }
        public string NickNameGamer { get; set; }
        public Gamer Gamer { get; set; }

        //public bool Escape()
        //{
        //    //METODO DA IMPLEMENTARE PER LA FUGA
        //SE LA FUGA RIESCE RESTITUISCO TRUE ALTRIMENTI FALSE
        //}


        public override string ToString()
        {
            return $"{Nome} - PuntiVita: {PuntiVita} - Livelllo: {Livello} " +
                $"- ArmaNome: {ArmaNome} ";
        }
    }
}
