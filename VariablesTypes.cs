using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_C_
{
    internal class VariablesTypes
    {
        static void Main(string[] args)
        {
            int idade;
            string nome;
            double altura;

            idade = 20;
            nome = "Matheus";
            altura = 1.70;

            Console.WriteLine($"Nome: {nome}\nIdade: {idade}\nAltura: {altura}");
        }
    }
}
