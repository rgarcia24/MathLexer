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
        public string attributeValue { get; }
        public enum TokenType
        {
            INTEGER,
            PLUS,
            MINUS,

        }
        public Token(TokenType type , string value)
        {
            tokenName = type;
            attributeValue = value;
        }


    }
}
