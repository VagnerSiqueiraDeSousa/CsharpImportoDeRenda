﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoDeRepeticaoFor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int linha = 0; linha < 10; linha++)
            { 
     // modoficamo o for que estava recebendo coluna < 10; "agora ele ficara coluna <= linha
                for(int coluna = 0; coluna <= linha; coluna++)
                {
                  /* otimizando o codigo
                   * 
                   * if(coluna > linha)
                    {
                        break;
                    }*/
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
