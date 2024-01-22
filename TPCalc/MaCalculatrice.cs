using System;

namespace TPCalc
{
    public class Calculatrice
    {
        public decimal Addition(decimal a, decimal b)
        {
            Console.WriteLine("Addition");
            return a + b;
            

        }

        public decimal Soustraction(decimal a, decimal b)
        {

            Console.WriteLine("Soustraction");
            return a - b;
        }

        public decimal Multiplication(decimal a, decimal b)
        {
            Console.WriteLine("Multiplication");
            return a * b;
        }
        public decimal Division(decimal a, decimal b)
        {
            Console.WriteLine("Division");
            return a / b;
        }
    }
}
