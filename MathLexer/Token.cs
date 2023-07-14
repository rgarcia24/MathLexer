using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLexer
{
    public class Token
    {
        public TokenType tokenName { get; }
        public string tokenValue { get; }

        public Token(TokenType type, string value)
        {
            tokenName = type;
            tokenValue = value;
        }
        public string toString()
        {
            return $"Token: {tokenName} Value: {tokenValue}";
        }
    }
    public enum TokenType
    {
        Integer,
        Identifier,
        Operator,
        Semicolon,
        Whitespace,
        Equals,
    }

   
}
