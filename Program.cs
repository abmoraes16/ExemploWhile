using System;

namespace ExemploWhile
{
    class Program
    {
        static decimal salario = 2;

        static void Main(string[] args)
        {
            while(salario<10) {
                Console.WriteLine("Seu salario e: "+(salario*=2));
            }   
        }
    }
}
