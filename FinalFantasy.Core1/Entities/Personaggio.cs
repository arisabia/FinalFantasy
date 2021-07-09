using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core1.Entities
{
    public class Personaggio
    {
        public int ID { get; set; }
        public string Nome { get; set; }
       // public int PuntiVita { get; set; }
        public int PuntiVita { get => CalcolaPunti(); }
        public int Livello { get; set; }
        //fk Arma
        public string ArmaNome { get; set; }
        public Arma Arma { get; set; }


        public virtual int Fight()
        {
            return Arma.PuntiDanno;
        //METODO CHE IMPLEMENTA L'AGGIORNAMENTO DEI PUNTI 
        //
        }

        private int CalcolaPunti()
        {
            Personaggio p = new Personaggio();
            int vita = 0;
            if (p.Livello == 1)
            {
                vita = 20;
            }
            if (p.Livello ==2)
            {
                vita = 40;
            }
            if (p.Livello == 3)
            {
                vita = 60;
            }
            if (p.Livello == 4)
            {
                vita = 80;
            }
            if (p.Livello == 5)
            {
                vita = 100;

            }
            return vita;
        }

       
    }
}
