using System;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ProductOf2ConsecutiveInt obj = new ProductOf2ConsecutiveInt();
            Console.WriteLine(obj.Solution(6, 20));
        }
    }
}
