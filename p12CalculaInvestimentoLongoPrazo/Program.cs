using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 12");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int countAno = 1; countAno <= 5; countAno++)
            {
                for (int countMes = 1; countMes <=12; countMes++)
                {
                    valorInvestido *= fatorRendimento;
                }

                fatorRendimento += 0.001;

            }

            Console.WriteLine("Ao término do investimento, você terá R$ " + valorInvestido);

            Console.ReadLine();
        }
    }
}
