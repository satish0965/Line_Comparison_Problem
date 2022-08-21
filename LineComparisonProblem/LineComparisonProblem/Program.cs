//Console.WriteLine("Welcome to Line Comparision Computation Problem");
using System;
namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To Line Comparison Computation Program==========");
            LineLength length = new LineLength();
            length.CalculateLength(); //Call The Methods
            length.CheckEquality();
            Console.ReadLine();
        }
    }
}
