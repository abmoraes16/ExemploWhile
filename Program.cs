using System;

namespace ExemploWhile
{
    class Program
    {
        static double salario = 100;

        static void Main(string[] args)
        {
            while(salario<5000) {
                Console.WriteLine(salario=salario*100);
            }   
        }
    }
}
