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
        public OperatorType opType { get; }
        public enum TokenState
        {
            Start,
            Integer,
            Float,
            Identifier,
            Operator,
            Hexadecimal,
            String,
            MaybeHex,
            WhiteSpace
        }

        public enum TokenType
        {
            Integer,
            Float,
            Identifier,
            Operator,
            Hexadecimal,
            String,
            Whitespace
        }
        public enum OperatorType
        {
            Plus,
            Minus,
            Multiply,
            Divide,
            Modulus,
            Assign,
            LessThan,
            GreaterThan,
            LessThanOrEqual,
            GreaterThanOrEqual,
            Equal,
            NotEqual,
            Not
        }

        public Token(TokenType type, string value)
        {
            tokenName = type;
            attributeValue = value;
            
        }
        public Token(TokenType type, string value, OperatorType operatorType)
        {
            tokenName = type;
            attributeValue = value;
            opType = operatorType;
        }



    }
}
