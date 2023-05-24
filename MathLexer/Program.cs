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
            Console.Write("Enter an Equation to Tokenize: ");
            string equation = Console.ReadLine();
            Lexer lexer = new Lexer(equation);

            List<Token> tokens = lexer.Tokenize();
            foreach (Token token in tokens)
            {
                Console.WriteLine($"Token: {token.tokenName}, Value: {token.attributeValue} ");
            }

            Console.Write("\n\nPress any key to exit....");
            Console.ReadKey();
        }
    }
}
