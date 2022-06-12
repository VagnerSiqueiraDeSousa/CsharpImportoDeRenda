using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoDeRenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa do Imposto de Renda, IR ");
            Console.WriteLine("");

            double salario = 1300.0;

            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("A sua aliquota é de 7%");
                Console.WriteLine("Você pode deduzir até R$ 142;");
            }
            else if (salario >= 2800.01 && salario <= 3751.0)
            {
                Console.WriteLine("A sua aliquota é de 15%");
                Console.WriteLine("Você pode  deduzir até R$ 350;");
            }

            else if (salario >= 3751.01 && salario <= 466400.0)
            {
                Console.WriteLine("A sua aliquota é de 22.5%");
                Console.WriteLine("Voc^pode deduzir até R$ 636");
            }

            else if (salario <= 1889.0) ;
            {
                Console.WriteLine("Você é insento ");
            }



            Console.WriteLine("");
            Console.WriteLine("Vagner finalize o programa pressionando enter");
            Console.ReadLine();
        }
    }
}
