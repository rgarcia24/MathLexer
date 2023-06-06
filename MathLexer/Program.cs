using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLexer
{
    class Program
    {
        static void Main(string[] args)
        {

            // Grab the equation from user input
                Console.Write("Enter an Equation to Tokenize: ");
                string equation = Console.ReadLine();
            //    string equation = "0x23AF + 0.55 - 1.55 * 24 / 86 % 2 > 41 < 8.23 >= 90 <= 9.12 == 23 != 45 myAge = 20 "Hello World"";

            // Initialize Lexer class and Tokenize the equation
                Console.WriteLine($"Tokenizing {equation}");
                Lexer MathLexer = new Lexer();
                MathLexer.Tokenize(equation);

                Console.Write("\n\nPress any key to exit....");
                Console.ReadKey();
            
         
       
        }
    }
}
