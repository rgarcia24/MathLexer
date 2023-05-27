using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLexer
{
    public class Lexer
    {

        public Lexer()
        {
            currentState = Token.TokenState.Start;
            currentToken = new StringBuilder();
        }


        private HashSet<char> Operators = new HashSet<char> { '+', '-', '*', '/', '=', '<', '>', '%', '!' };


        private StringBuilder currentToken = new StringBuilder();
        private Token.TokenState currentState = Token.TokenState.Start;
       
        public  void Tokenize(string equation)
        {
          

            for (int i = 0; i < equation.Length; i++)
            {
                char c = equation[i];

                switch (currentState)
                {
                    case Token.TokenState.Start:
                        Scan(c);
                        break;

                    case Token.TokenState.MaybeHex:
                       if(c == 'x')
                        {
                            nextChar(Token.TokenState.Hexadecimal, c);
                        }
                        else
                        {
                            nextChar(Token.TokenState.Integer, c);
                        }
                        break;

                    case Token.TokenState.Integer:

                        if(c == '.')
                        {
                            nextChar(Token.TokenState.Float, c);

                        }
                        else if (char.IsDigit(c))
                        {
                            nextChar(Token.TokenState.Integer, c);
                        }
                        else
                        {
                            
                            produceToken(Token.TokenType.Integer, currentToken, c);
                        }
                       
                        break;

                    case Token.TokenState.Float:
                        if (char.IsDigit(c))
                        {
                            nextChar(Token.TokenState.Float, c);
                        }else
                        {
                            if (!char.IsWhiteSpace(c))
                            {
                                Console.WriteLine($"Unexpected character: {c}");
                                Console.Write("Press any key to exit....");
                                Console.ReadKey();
                                Environment.Exit(1);
                            }else
                            {
                                produceToken(Token.TokenType.Float, currentToken, c);
                            }

                           
                        }
                        break;

                    case Token.TokenState.Identifier:
                        if (char.IsLetter(c) || c == '_')
                        {
                            nextChar(Token.TokenState.Identifier, c);
                        }else
                        {
                            produceToken(Token.TokenType.Identifier, currentToken, c);
                        }
                        
                        break;

                    case Token.TokenState.Operator:
                        if (Operators.Contains(c))
                        {
                            nextChar(Token.TokenState.Operator, c);
                        }
                        else
                        {
                            handleOperators(currentToken.ToString(), c);
                        }
                        break;

                    case Token.TokenState.Hexadecimal:
                        if(char.IsLetter(c) || char.IsDigit(c)) 
                        {
                            nextChar(Token.TokenState.Hexadecimal, c);
                        }else
                        {
                            produceToken(Token.TokenType.Hexadecimal, currentToken, c);
                        }
                        break;

                    case Token.TokenState.String:
                        if(c == '"')
                        {
                            produceToken(Token.TokenType.String, currentToken);
                        }
                        else
                        {
                            nextChar(Token.TokenState.String, c);
                        }
                        break;

                    case Token.TokenState.WhiteSpace:
              
                        if(char.IsWhiteSpace(c))
                        {
                            nextChar(Token.TokenState.WhiteSpace, c);
                        }
                        else
                        {
                            produceToken(Token.TokenType.Whitespace, currentToken, c);
                        }
                        break;
                }
            }

            switch (currentState)
            {
                case Token.TokenState.Integer:
                    produceToken(Token.TokenType.Integer, currentToken);
                    break;
                case Token.TokenState.Float:
                    produceToken(Token.TokenType.Float, currentToken);
                    break;
                case Token.TokenState.Hexadecimal:
                    produceToken(Token.TokenType.Hexadecimal, currentToken);
                    break;
                case Token.TokenState.Operator:
                    handleOperators(currentToken.ToString());
                    break;
                case Token.TokenState.String:
                    produceToken(Token.TokenType.String, currentToken);
                    break;
                case Token.TokenState.Identifier:
                    produceToken(Token.TokenType.Identifier, currentToken);
                    break;
                case Token.TokenState.WhiteSpace:
                    produceToken(Token.TokenType.Whitespace, currentToken);
                    break;
                
            }
        }

        private void Scan(char c)
        {

            switch (c)
            {
                case char num when char.IsDigit(num):
                    handleNumbers(c);
                    break;
                case char identifier when  char.IsLetter(identifier) || identifier == '_':
                    nextChar(Token.TokenState.Identifier, c);
                    break;
                case char @operator when Operators.Contains(@operator):
                    nextChar(Token.TokenState.Operator, c);
                    break;
                case '"':
                    nextChar(Token.TokenState.String);
                    break;
                case char whitespace when char.IsWhiteSpace(whitespace):
                    nextChar(Token.TokenState.WhiteSpace, c);
                    break;
                default:
                    Console.WriteLine("Invalid Character: " + c);
                    Console.Write("Press any key to exit...");
                    Console.ReadKey();
                    Environment.Exit(1);
                    break;
            }
            

        }

        private void produceToken(Token.TokenType tokenName, StringBuilder tokenValue, char c)
        {
            Console.WriteLine($"Token: {tokenName} Value: {tokenValue} ");
            currentToken.Clear();
            currentState = Token.TokenState.Start;
            Scan(c);
        }

        private void produceToken(Token.TokenType tokenName, StringBuilder tokenValue)
        {
            Console.WriteLine($"Token: {tokenName} Value: {tokenValue} ");
            currentToken.Clear();
            currentState = Token.TokenState.Start;
        }

        private void produceToken(Token.OperatorType tokenName, StringBuilder tokenValue, char  c)
        {
            Console.WriteLine($"Token: {tokenName} Value: {tokenValue} ");
            currentToken.Clear();
            currentState = Token.TokenState.Start;
            Scan(c);
        }

        private void produceToken(Token.OperatorType tokenName, StringBuilder tokenValue)
        {
            Console.WriteLine($"Token: {tokenName} Value: {tokenValue} ");
            currentToken.Clear();
            currentState = Token.TokenState.Start;
        }



        private void nextChar(Token.TokenState state, char c)
       {
            currentState = state;
            currentToken.Append(c);
       }
        private void nextChar(Token.TokenState state)
        {
            currentState = state;
        }


      private void handleNumbers(char c)
       {
            if (c == '0')
            {
                nextChar(Token.TokenState.MaybeHex, c);
            }
            else
            {
                nextChar(Token.TokenState.Integer, c);
       
            }
       }

      private void handleOperators(string currToken, char c)
       {
            switch (currToken)
            {
                case "+":
                    produceToken(Token.OperatorType.Plus, currentToken, c);
                    break;
                case "-":
                    produceToken(Token.OperatorType.Minus, currentToken, c);
                    break;
                case "*":
                    produceToken(Token.OperatorType.Multiply, currentToken, c);
                    break;
                case "/":
                    produceToken(Token.OperatorType.Divide, currentToken, c);
                    break;
                case "%":
                    produceToken(Token.OperatorType.Modulus, currentToken);
                    break;
                case "<":
                    produceToken(Token.OperatorType.LessThan, currentToken, c);
                    break;
                case ">":
                    produceToken(Token.OperatorType.GreaterThan, currentToken, c);
                    break;
                case ">=":
                    produceToken(Token.OperatorType.GreaterThanOrEqual, currentToken, c);
                    break;
                case "<=":
                    produceToken(Token.OperatorType.LessThanOrEqual, currentToken, c);
                    break;
                case "=":
                    produceToken(Token.OperatorType.Assign, currentToken, c);
                    break;
                case "==":
                    produceToken(Token.OperatorType.Equal, currentToken, c);
                    break;
                case "!":
                    produceToken(Token.OperatorType.Not, currentToken, c);
                    break;
                case "!=":
                    produceToken(Token.OperatorType.NotEqual, currentToken, c);
                    break;
                default:
                    Console.WriteLine($"Unexpected operator: {currentToken}");
                    Console.Write("Press any key to exit...");
                    Console.ReadKey();
                    Environment.Exit(1);
                    break;
            }
          
        }
        private void handleOperators(string currToken)
        {
            switch (currToken)
            {
                case "+":
                    produceToken(Token.OperatorType.Plus, currentToken);
                    break;
                case "-":
                    produceToken(Token.OperatorType.Minus, currentToken);
                    break;
                case "*":
                    produceToken(Token.OperatorType.Multiply, currentToken);
                    break;
                case "/":
                    produceToken(Token.OperatorType.Divide, currentToken);
                    break;
                case "%":
                    produceToken(Token.OperatorType.Modulus, currentToken);
                    break;
                case "<":
                    produceToken(Token.OperatorType.LessThan, currentToken);
                    break;
                case ">":
                    produceToken(Token.OperatorType.GreaterThan, currentToken);
                    break;
                case ">=":
                    produceToken(Token.OperatorType.GreaterThanOrEqual, currentToken);
                    break;
                case "<=":
                    produceToken(Token.OperatorType.LessThanOrEqual, currentToken);
                    break;
                case "=":
                    produceToken(Token.OperatorType.Assign, currentToken);
                    break;
                case "==":
                    produceToken(Token.OperatorType.Equal, currentToken);
                    break;
                case "!":
                    produceToken(Token.OperatorType.Not, currentToken);
                    break;
                case "!=":
                    produceToken(Token.OperatorType.NotEqual, currentToken);
                    break;
                default:
                    Console.WriteLine($"Unexpected operator: {currentToken}");
                    Console.Write("Press any key to exit...");
                    Console.ReadKey();
                    Environment.Exit(1);
                    break;
            }

        }





    }

}
