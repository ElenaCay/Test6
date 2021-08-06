using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test6.Classi;

namespace Test6
{
    class Operazioni
    {
        public static void CreaConto()
        {
            Console.WriteLine("Inserisci il nuovo numero di conto");
            string conto = Console.ReadLine();
            Console.WriteLine("Inserisci il nome della banca");
            string nome = Console.ReadLine();
            ContoCorrente contoCorrente = new ContoCorrente(conto, nome);
        }
    }
}
