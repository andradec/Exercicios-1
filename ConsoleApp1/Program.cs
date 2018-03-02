using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ano, mes, dia;

            System.Console.WriteLine("Informe o ano de nascimento ");
            ano = Console.ReadLine();
            int anof =  Convert.ToInt32(ano);
            int anofinal = (2017 - anof);

            int diaAno = (anofinal * 365);
            
            System.Console.WriteLine("Informe o mes do seu nascimento");
            mes = Console.ReadLine();
            int mesfinal = Convert.ToInt32(mes);

            int diaMes = (mesfinal * 30);

            System.Console.WriteLine("Informe o dia do seu nascimento");
            dia = Console.ReadLine();

            int diaFinal = (diaAno + diaMes);


            System.Console.WriteLine("Sua idade em dias eh : " + diaFinal);

            Console.ReadKey();

        }
    }
}
