using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8");

            int idade = 18;
            //int quantidadePessoas = 2;
            //bool acompanhado = quantidadePessoas >= 2;
            bool acompanhado = true;

            //considerando operadores lógicos para refatoração
            if (idade >= 18 || acompanhado == true)
            {
                Console.WriteLine("Entrada autorizada!");
            }
            else
            {
                Console.WriteLine("Entrada não autorizada!");
            }

            Console.ReadLine();
        }
    }
}
