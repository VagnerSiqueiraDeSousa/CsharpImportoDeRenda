using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplosDeTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);
                   
                }
                
            }
            Console.WriteLine("nova execução com o For diferente");
            for (int i = 2; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
    
}
    

