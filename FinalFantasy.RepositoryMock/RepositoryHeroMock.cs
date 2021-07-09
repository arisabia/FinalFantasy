using FinalFantasy.Core1.Entities;
using FinalFantasy.Core1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryMock
{
    public class RepositoryHeroMock : IRepositoryHero
    {
        private ICollection<Hero> Heroes = new List<Hero>()
        {
            new Hero {
                ID = 1, Nome = "Soldier", Livello = 1, ArmaNome = "Mazza ", PuntiLivello = 5, NickNameGamer = "DragonStar" },

        };
        public bool Add(Hero hero)
        {
            if (hero != null)
            {
                Heroes.Add(hero);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(Hero hero)
        {
            var heroToDelete = Heroes.FirstOrDefault(h => h.ID == hero.ID);
            return Heroes.Remove(heroToDelete);
        }

        public ICollection<Hero> GetAll()
        {
            return Heroes;
        }

        public Hero GetById(int id)
        {
            if (id > 0)
            {
                foreach (Hero hero in Heroes)
                {
                    if (hero.ID == id)
                    {
                        return hero;
                    }
                }
                Console.WriteLine("erore");
                return null;
            }
            else
            {
                return null;
            }
            
        }

        Hero IRepositoryHero.Add(Hero hero)
        {
            throw new NotImplementedException();
        }
    }
}
