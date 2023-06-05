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

                // Initialize Lexer class and Tokenize the equation
                Lexer MathLexer = new Lexer();
                 MathLexer.Tokenize(equation);

                Console.Write("\n\nPress any key to exit....");
                Console.ReadKey();
            
         
       
        }
    }
}
