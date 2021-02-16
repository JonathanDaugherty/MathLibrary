using System;

namespace MathLibrary {
    class Program {
        static void Main(string[] args) {

            //var math = new Math();
            var answer = Math.Add(1, 2);
            Console.WriteLine($"1 plus 2 equals {answer}");

            var answer2 = Math.Subtract(7, 2);
            Console.WriteLine($"7 minus 2 equals {answer2}");

            var answer3 = Math.Multiply(7, 2);
            Console.WriteLine($"7 times 2 equals {answer3}");

            var answer4 = Math.Divide(7, 2);
            Console.WriteLine($"7 divided by 2 equals {answer4}");

            var answer5 = Math.Modulo(7, 2);
            Console.WriteLine($"7 Modulo 2 equals {answer5}");

            var a = 2;
            var b = 4;
            var answer6 = Math.Power(a, b);
            Console.WriteLine($"{a} Power {b} equals {answer6}");

            a = 2;
            bool boolAnswer = Math.IsEven(a);
            Console.WriteLine($"{a} is {(boolAnswer ? "Even" : "Odd")}");

            a = 67;
            boolAnswer = Math.IsEven(a);
            Console.WriteLine($"{a} is {(boolAnswer ? "Even" : "Odd")}");

            a = 88;
                Console.WriteLine($"{ a} incremented is {Math.increment(a)}");
                Console.WriteLine($"{ a} decremented is {Math.decrement(a)}");

            a = Math.increment(a);
        }
    }
}
