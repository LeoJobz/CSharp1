using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7");

            int idade = 18;
            int quantidadePessoas = 0;

            if (idade >= 18)
            {
                Console.WriteLine("Joao é maior de idade, entrada autorizada.");
            }
            else if (quantidadePessoas >= 2)
            {
                Console.WriteLine("João é menor de idade, porém está acompanhado. Entrada autorizada.");
            }
            else
            {
                Console.WriteLine("João é menor de idade e não está acompanhado. Entrada não autorizada.");
            }



            Console.ReadLine();
        }
    }
}
