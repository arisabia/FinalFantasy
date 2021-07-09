using FinalFantasy.Core1.Entities;
using FinalFantasy.RepositoryMock;
using System;

namespace FinalFantasy
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositoryGamerMock repoGamer = new RepositoryGamerMock();

            Gamer gamer = Gaming.MenuIniziale();
            Console.WriteLine(gamer);
            if (gamer != null)
            {
                bool esito = Gaming.MenuGiocatore(gamer);
            }
        }
    }
}
