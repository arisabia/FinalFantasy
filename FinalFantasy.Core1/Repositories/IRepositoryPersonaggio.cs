using FinalFantasy.Core1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core1.Repositories
{
    public interface IRepositoryPersonaggio : IRepository<Personaggio>
    {
       // public Personaggio GetByNome(string nome);
        public Personaggio Add(Personaggio personaggio);
        public bool Delete(Personaggio  personaggio);
        public ICollection<Personaggio> GetAll();


    }
}
