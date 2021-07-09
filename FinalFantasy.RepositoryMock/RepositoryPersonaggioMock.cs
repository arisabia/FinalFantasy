using FinalFantasy.Core1.Entities;
using FinalFantasy.Core1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryMock
{
    public class RepositoryPersonaggioMock : IRepositoryPersonaggio
    {
        public Personaggio Add(Personaggio personaggio)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Personaggio personaggio)
        {
            //var heroToDelete = Personaggio.FirstOrDefault(h => h.ID == personaggio.ID);
            //return Personaggi.Remove(heroToDelete);
            throw new NotImplementedException();
        }

        public ICollection<Personaggio> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
