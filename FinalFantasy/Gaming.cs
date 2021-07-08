using FinalFantasy.Core1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy
{
    public class Gaming
    {
        public static bool SchermoMenuIniziale()
        {
            Console.WriteLine("1. Accedi");
            Console.WriteLine("2. Registrati");
            Console.WriteLine("3. Esci");
            int scelta = Gaming.VerificaInput(3);
            var esito = Gaming.AnalizzaSceltaIniziale(scelta);

            return esito;
        }

        private static bool AnalizzaSceltaIniziale(int scelta)
        {
            bool go = true;
            switch (scelta)
            {
                case 1:
                    Gaming.LogInUtente();
                    break;
                case 2:
                    Gaming.CreaUtente();
                    break;
                case 3:
                    Console.WriteLine("Alla prossima partita");
                    break;
                default:
                    go = false;
                    break;
            }
            return go;
        }

        private static void CreaUtente()
        {
            throw new NotImplementedException();
        }

        //MENU INIZIALE DI GESTIONE DELL'UTENTE
        public static Utente MenuIniziale()
        {

            throw new NotImplementedException();

        }

        //MENU PRINCIPALE DI INIZIO PARTITA
        public static bool MenuGiocatore(Utente utente)
        {
            //ALL'INTERNO DI QUESTO MENU VADO A GESTIRE LE OPERAZIONI
            //INIZIALE DI CREAZIONE PARTITA
            //CREAZIONE EROE
            //SCELTA EROE
            //ELIMINARE EROE
            Console.WriteLine("1. Gioca");
            Console.WriteLine("2. Crea nuovo eroe");
            Console.WriteLine("3. Elimina eroe");
            Console.WriteLine("4. Esci");
            int scelta = Gaming.VerificaInput(4);
            var esito = Gaming.AnalizzaScelta(scelta);
            return esito;


        }

        private static int VerificaInput(int max)
        {
            var conversione = int.TryParse(Console.ReadLine(), out int result);
            while (conversione == false || result < 0 || result > max)
            {
                conversione = int.TryParse(Console.ReadLine(), out result);
            }
            return result;
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
                    Gaming.SchermoMenuIniziale();
                    break;
                    
                default:
                    go = false;
                    break;
            }
            return go;
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
            throw new NotImplementedException();
        }

        private static void Gioca()
        {
            //Se si sceglie “Gioca”, l’applicazione mostrerà tutti gli eroi
            //di quel giocatore e il giocatore potrà scegliere con quale
            //eroe continuare la partita(il seguito viene spiegato dopo).


            throw new NotImplementedException();
        }

        public static void Partita(Eroe eroeScelto)
        {
            //METODO ALL'INTERNO DEL QUALE VADO A GESTIRE 
            //LA LOGICA RELATIVA AD UNA PARTITA

        }

        public static void Battaglia(Eroe eroeScelto, Mostro mostroSorteggiato)
        {
            //ALL'INTERNO DI QUESTO METODO VENGONO GESTITE LE CASISTICHE DI 
            //VITTORIA-PERDITA DELL'EROE
            //LA BATTAGLIA SI RIPETE FINCHE' L'EROE NON UCCIDE IL MOSTRO O VICEVERSA
        }

        public static bool SceltaTurno(Eroe eroe, Mostro mostro)
        {
            //METODO CHE CHIEDE ALL'UTENTE QUALE MOSSA ESEGUIRE
            //LOTTA O FUGA
        }
        public static Utente LogInUtente()
        {
            Console.WriteLine("Inserisci i tuoi dati");
            Console.Write("Username -> ");
            string username = Console.ReadLine();
            Console.Write("Password -> ");
            string password = Console.ReadLine();
            foreach (var utente in Utenti)
            {
                if (utente.Username == username && utente.Password == password)
                {
                    return utente;
                }
            }
            return null;
        }
    }
}
