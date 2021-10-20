using System;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double valorcarro, a, b, c, d;
            double l = 0.1428;
            double i = 0.13;
           
            Console.WriteLine("O Valor do carro: ");
            valorcarro = double.Parse(Console.ReadLine());
            Console.WriteLine("Lucro da distribuidora é " +l*100+ " % ");
           
            Console.WriteLine("O valor dos impostos é " +i*100+ " % ");
           
            a = valorcarro * l;
            b = valorcarro * i;
            c = a + b;
            d = valorcarro + c;

            Console.WriteLine("O valor do lucro da distribuidora é: " +a);
            Console.WriteLine("O valor do imposto é: " +b);
            Console.WriteLine("O valor do carro com imposto é: " + d);





        }
    }
}
