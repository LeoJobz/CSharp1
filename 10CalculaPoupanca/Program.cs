using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10");

            double valorInvestido = 1000;
            int countMes = 1;

            
            
            while (countMes <= 12)
            {
                //0.36% = 0.0036
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + countMes + " meses, você terá R$ " + valorInvestido);

                //countMes = countMes + 1;
                //countMes += 1;
                countMes++;
            }

            Console.ReadLine();
        }
    }
}
