using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double valorInvestido = 1000;

            for (int countMes = 0; countMes <= 12; countMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + countMes + " meses você terá R$ " + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}
