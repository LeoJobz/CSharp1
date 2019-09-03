using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            //character
            Console.WriteLine("Executando projeto 5");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            //string
            string titulo = "Alura Cursos de Tecnologia " + 2020;
            Console.WriteLine(titulo);

            string cursosProgramacao = 
@"Java,
CSharp,
JavaScript";
            Console.WriteLine(cursosProgramacao);

            Console.ReadLine();
        }
    }
}
