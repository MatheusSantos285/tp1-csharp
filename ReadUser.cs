using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_C_
{
    internal class ReadUser
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Digite o seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine($"Hello, {nome}!");
        }
    }
}
