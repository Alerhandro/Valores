using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um valor");

            int Valor = Convert.ToInt32(Console.ReadLine());

            if (Valor >= 20)
            {
                Console.WriteLine("maior que vinte ");
            }
            else
            {
                Console.WriteLine("menor que vinte");
            }



        }
    }
}
