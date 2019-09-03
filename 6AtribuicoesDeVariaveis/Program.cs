using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6");

            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine("A idade de gustavo e: " + idadeGustavo);

            Console.ReadLine();
        }
    }
}
