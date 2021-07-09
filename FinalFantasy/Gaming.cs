using FinalFantasy.Core1.Entities;
using FinalFantasy.Core1.Repositories;
using FinalFantasy.RepositoryMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy
{
    public class Gaming
    {
        static IRepositoryGamer repoGamer = new RepositoryGamerMock();
        static IRepositoryArma repoArma = new RepositoryArmaMock();
        static IRepositoryHero repoHero = new RepositoryHeroMock();
        static IRepositoryMonster repoMonster = new RepositoryMonsterMock();
        


        //MENU INIZIALE DI GESTIONE DELL'UTENTE
        public static Gamer MenuIniziale()
        {
            RepositoryGamerMock repoGamer = new RepositoryGamerMock();
            //int scelta = 0;
           
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Exit");
            int scelta = VerificaInput(3);
            switch (scelta)
            {
                case 1:
                    Console.WriteLine("Insert NickName:");
                    string nickName = Console.ReadLine();
                    return repoGamer.GetByNickName(nickName);
                case 2:
                    //Registrazione
                    Console.WriteLine("Insert NickName to register:");
                    string newNickName = Console.ReadLine();
                    while (newNickName.Length == 0)
                    {
                        Console.WriteLine("NickName must me be longer, retry:");
                        newNickName = Console.ReadLine();
                    }
                    Gamer newGamer = new Gamer() { NickName = newNickName };
                    repoGamer.Add(newGamer);
                    return newGamer;
                case 3:
                    Console.WriteLine("See you soon!");
                    break;
                default:
                    return null;
                    break;
            }
            return null;

       

        }

        //MENU PRINCIPALE DI INIZIO PARTITA
        public static bool MenuGiocatore(Gamer gamer)
        {
            //ALL'INTERNO DI QUESTO MENU VADO A GESTIRE LE OPERAZIONI
            //INIZIALE DI CREAZIONE PARTITA
            //CREAZIONE EROE
            //SCELTA EROE
            //ELIMINARE EROE

            //utenti non admin
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Create new hero");
            Console.WriteLine("3. Cancel hero");
            Console.WriteLine("4. Exit");
            int scelta = Gaming.VerificaInput(4);
            var esito = Gaming.AnalizzaScelta(scelta);
            return esito;

        }

       

        private static bool AnalizzaScelta(int scelta)
        {
            bool go = true;
            switch (scelta)
            {
                case 1:
                    Gaming.Gioca();
                    break;
                case 2:
                    Gaming.CreaNuovoEroe();
                    break;
                case 3:
                    Gaming.EliminaEroe();
                    break;
                case 4:
                    Gaming.MenuIniziale();
                    break;
                    
                default:
                    go = false;
                    break;
            }
            return go;
        }
        private static void CreatGamer()
        {
            throw new NotImplementedException();
        }
        private static void EliminaEroe()
        {
            //Se si sceglie “Elimina eroe”, verranno mostrati tutti gli eroi
            //e l’utente sceglierà quale eroe cancellare.
           // A cancellazione avvenuta, si visualizzerà il seguente
           // messaggio: “L’eroe è stato cancellato ”.



            throw new NotImplementedException();
        }

        private static void CreaNuovoEroe()
        {
            //Se si sceglie “Crea nuove eroe”, l’applicazione chiederà all’utente
            //di inserire il nome dell’eroe, la categoria dell’eroe, l’arma e
            //visualizzerà il messaggio “Eroe inserito” e ritornerà al Menù
            Console.WriteLine("Insert Hero's Name");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Insert Hero's Gun");
            string arma = Console.ReadLine();
            Hero hero = new Hero()
            {
                Nome = nome,
                ArmaNome = arma,
            };

            repoHero.Add(hero);
            
                Console.WriteLine("Hero Added");
            
            


           
        }

        private static int Gioca()
        {
            //Se si sceglie “Gioca”, l’applicazione mostrerà tutti gli eroi
            //di quel giocatore e il giocatore potrà scegliere con quale
            //eroe continuare la partita(il seguito viene spiegato dopo).
            Console.WriteLine("Lista Eroi");
            var heroes = repoHero.GetAll();
            var chosenHero = 0;
            if (heroes.Count == 0)
            {
                Console.WriteLine("Heroes not foud");

            }
            else
            {
                Helper.StampaCollection(heroes);
                var numMax = heroes.Max(h => h.ID);
                chosenHero = VerificaInput(numMax);
            }
           
           return chosenHero;

            
        }

        public static void Partita(Hero heroChosen)
        {
            //METODO ALL'INTERNO DEL QUALE VADO A GESTIRE 
            //LA LOGICA RELATIVA AD UNA PARTITA

        }

        public static void Battaglia(Hero heroChosen, Hero mostroSorteggiato)
        {
            //ALL'INTERNO DI QUESTO METODO VENGONO GESTITE LE CASISTICHE DI 
            //VITTORIA-PERDITA DELL'EROE
            //LA BATTAGLIA SI RIPETE FINCHE' L'EROE NON UCCIDE IL MOSTRO O VICEVERSA
        }

        //public static bool SceltaTurno(Hero hero, Monster monster)
        //{
        //    //METODO CHE CHIEDE ALL'UTENTE QUALE MOSSA ESEGUIRE
        //    //LOTTA O FUGA
        //}

        private static int VerificaInput(int max)
        {
            var conversione = Int32.TryParse(Console.ReadLine(), out int result);
            while (conversione == false || result < 0 || result > max)
            {
                Console.WriteLine("Choose one of the options available");
                conversione = int.TryParse(Console.ReadLine(), out result);
            }
            return result;
        }

    }
}
