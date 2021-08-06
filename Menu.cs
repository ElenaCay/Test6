using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test6.Classi;

namespace Test6
{
    class Menu
    {
        public static void Start()
        {
            Console.WriteLine("Benvenuto, gestisci il tuo conto corrente!");

            char choice;
            do
            {
                Console.WriteLine("Premi 1 per aprire un conto corrente");
                Console.WriteLine("Premi 2 per prelevare");
                Console.WriteLine("Premi 3 per versare");
                Console.WriteLine("Premi 4 per fare un bonifico");
                Console.WriteLine("Premi 5 per usare la carta di credito");

                Console.WriteLine("Premi q per uscire");

                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (choice)
                {
                    case '1':
                        Console.Clear();
                        Operazioni.CreaConto();
                        Console.WriteLine();
                        break;
                    case '2':
                        Console.Clear();
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case 'q':
                        //Esci
                        Console.WriteLine("\nCiao!");
                        return;
                    default:
                        Console.WriteLine("Scelta non disponibile. Riprova!");
                        break;
                }

            } while (!(choice == 'q'));
        }
    }
}
