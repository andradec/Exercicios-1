using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a quantidade de votos Brancos ?");
            string votoBranco = Console.ReadLine();

            Console.WriteLine("Qual a quantidade de votos Nulos ?");
            string votosNulos = Console.ReadLine();

            Console.WriteLine("Qual a quantidade de votos validos ");
            string votosValidos = Console.ReadLine();

            int  branco = Convert.ToInt32(votoBranco);
            int  nulo = Convert.ToInt32(votosNulos);
            int validos = Convert.ToInt32(votosValidos);

            int total = (branco + nulo + validos);

            Console.WriteLine("O total de votos eh: " +total);

            Console.WriteLine("O percentual de votos branco eh :" + ((branco * 100) / total) + "%");
            Console.WriteLine("O percentual de votos Nulos eh :" + ((nulo * 100) / total) + "%");
            Console.WriteLine("O percentual de votos validos eh :" + ((validos * 100) / total) + "%");

            Console.ReadKey();

        }
    }
}
