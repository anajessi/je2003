using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace je2003
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double b;
            string nome;
            string sobrenome;

            a = 10;
            b = 11.5;
            nome = "pato donald";

            Console.WriteLine("digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("digite seu sobrenome");
            sobrenome = Console.ReadLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(nome);
            Console.WriteLine(sobrenome);
            Console.WriteLine(nome + " " + sobrenome);
            Console.ReadLine();

        }
    }
}
