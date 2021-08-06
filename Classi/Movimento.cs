using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6.Classi
{
    public class Movimento
    {
        public decimal Importo { get; set; }
        public DateTime DataMovimento { get { return DateTime.Now; }  }
        public ContoCorrente Conto { get; set; }


        public void Prelevamento()
        {
            Console.WriteLine("Quale importo vuoi prelevare?");
            decimal.TryParse(Console.ReadLine(), out decimal importo);
            this.Conto.Saldo = this.Conto.Saldo - importo;
        }

        public void Versamento()
        {
            Console.WriteLine("Quale importo vuoi versare?");
            decimal.TryParse(Console.ReadLine(), out decimal importo);
            this.Conto.Saldo = this.Conto.Saldo + importo;
        }

    }
}
