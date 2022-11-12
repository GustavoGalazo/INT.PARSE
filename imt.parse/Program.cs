using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imt.parse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira dois valores");
            string valor01 = Console.ReadLine();
            string valor02 = Console.ReadLine();
            Console.WriteLine("escreva um terceiro valor para ser somado.");
            string valor03 = Console.ReadLine();
            int num2 = Int32.Parse(valor02);
            int num1 = Int32.Parse(valor01);
            int num3 = Int32.Parse(valor03);
            int resultado = num1 * num2;
            int resultado2 = resultado + num3;
            Console.WriteLine("Resultado:" +resultado2.ToString());
            Console.ReadKey();
            
        }
    }
}
