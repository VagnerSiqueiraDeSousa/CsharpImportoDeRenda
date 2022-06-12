using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imprimindoNunFatoriais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1;
            for (int contador = 1; contador < 11; contador++)
            {
                fatorial *= contador;
                Console.Write("Fatorial de " + contador + " = " + fatorial);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
