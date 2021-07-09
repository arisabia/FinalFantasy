using FinalFantasy.Core1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core1.Repositories
{
    public interface IRepositoryHero : IRepository<Hero>
    {
        public Hero GetById(int id);
        public Hero Add(Hero hero);
        public bool Delete(Hero hero);
        public ICollection<Hero> GetAll();
       // public IList<Hero> GetHeroesByUser(User user);
    }
}
