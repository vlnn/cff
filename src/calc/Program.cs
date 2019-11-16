using System;

namespace calc {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Calc calc = new Calc();
            Console.WriteLine(calc.Add("2,3"));
        }
    }
}
