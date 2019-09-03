using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ConversaoEOutrosTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4");

            double salario;
            salario = 1200.50;

            int salarioInteiro;
            //casting
            salarioInteiro = (int)salario;


            Console.WriteLine("int: " + salarioInteiro + " / double: " + salario);

            Console.ReadLine();
        }
    }
}
