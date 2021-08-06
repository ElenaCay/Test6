using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6.Classi
{
    public class ContoCorrente
    {
        public string NumeroConto { get; set; }
        public string NomeBanca { get; set; }
        public decimal Saldo { get; set; }
        public DateTime DataUltimaOperazione { get; set; }

        public IList<Movimento> Movimenti = new List<Movimento>();

        public ContoCorrente(string NumConto, string NomeB)
        {
            NumeroConto = NumConto;
            NomeBanca = NomeB;
        }
    }
}
