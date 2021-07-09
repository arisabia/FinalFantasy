using FinalFantasy.Core1.Entities;
using FinalFantasy.Core1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryMock
{
    public class RepositoryMonsterMock : IRepositoryMonster
    {
        public ICollection<Monster> GetAll()
        {
            throw new NotImplementedException();
        }
        private ICollection<Monster> Monsters = new List<Monster>()
        {
             new Monster { ID = 1, Nome = "Lucifero", Livello = 1, ArmaNome = "Fulmine "},
              new Monster { ID = 2, Nome = "Ghost", Livello = 1, ArmaNome = "Clava"},
               new Monster { ID = 3, Nome = "Lucifer", Livello = 1, ArmaNome = "Divinazione"}
        };
        public Monster GetById(int id)
        {
           
            if (id > 0)
            {
                foreach (Monster monster in Monsters)
                {
                    if (monster.ID == id)
                    {
                        return monster;
                    }
                }
                Console.WriteLine("Error");
                return null;
            }
            else
            {
                return null;
            }
        }

        public IList<Monster> GetMonsterByLevel(int livello)
        {
            throw new NotImplementedException();
        }
    }
}
