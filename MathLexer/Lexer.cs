using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLexer
{
    public class Lexer
    {
        private readonly string equation;
        private int position;

        public Lexer(string equation)
        {
            this.equation = equation;
            position = 0;
            
        }

        public List<Token> Tokenize()
        {
            List<Token> tokens = new List<Token>();

            while (position < equation.Length)
            {
                char currentChar = equation[position];

                if (char.IsWhiteSpace(currentChar))
                {
                    position++;
                    continue;
                }

                switch (currentChar)
                {
                    case '+':
                        tokens.Add(new Token(Token.TokenType.PLUS, "+"));
                        break;
                    case '-':
                        tokens.Add(new Token(Token.TokenType.MINUS, "-"));
                        break;
                    default:
                        if (IsDigit(currentChar))
                        {
                            string integer = AcceptInteger();
                            tokens.Add(new Token(Token.TokenType.INTEGER, integer));
                        }
                        else
                        {
                            Console.WriteLine("Invalid Character: " + currentChar);
                            Console.Write("Press any key to exit...");
                            Console.ReadKey();
                            System.Environment.Exit(1);

                        }
                        break;
                }

                position++;
            }

            return tokens;
        }


        private string AcceptInteger()
        {
            int startPosition = position;

            while (position < equation.Length && IsDigit(equation[position]))
            {
                position++;
            }

            return equation.Substring(startPosition, position - startPosition);
        }

        private bool IsDigit(char c)
        {
            return c >= '0' && c <= '9';
        }
    }



}
