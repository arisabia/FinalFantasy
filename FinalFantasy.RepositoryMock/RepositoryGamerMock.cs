﻿using FinalFantasy.Core1.Entities;
using FinalFantasy.Core1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryMock
{
    public class RepositoryGamerMock : IRepositoryGamer
    {
        private ICollection<Gamer> Gamers = new List<Gamer>()
        {
            new Gamer { NickName = "LarisaDragon" },
            new Gamer { NickName = "DragonStar" }
        };
        public Gamer Add(Gamer gamer)
        {
            if (gamer != null)
            {
                foreach (Gamer g in Gamers)
                {
                    if (g.NickName == gamer.NickName)
                    {
                        Console.WriteLine("NickName esistente");
                        return null;
                    }
                }
                Gamers.Add(gamer);
                Console.WriteLine("NickName registrato");
                return gamer;
            }
            else
            {
                Console.WriteLine("Non hai inserito nessun Nickname");
                return null;
            }
          
        }

        public ICollection<Gamer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Gamer GetByNickName(string nickName)
        {
            if (nickName != null)
            {
                foreach (Gamer gamer in Gamers)
                {
                    if (gamer.NickName == nickName)
                    {
                        return gamer;
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
    }
}
