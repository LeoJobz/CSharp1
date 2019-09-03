using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9");

            int idade = 16;
            bool acompanhado = true;
            string mensagemAdicional;


            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado.";
            }
            else
            {
                mensagemAdicional = "João não está acompanhado.";
            }
            //considerando operadores lógicos para refatoração
            if (idade >= 18 || acompanhado == true)
            {
                Console.WriteLine("Entrada autorizada!");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Entrada não autorizada!");
            }

            Console.ReadLine();
        }
    }
}
