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
         
            
            string code = "int num = 10;";
            Lexer lexer = new Lexer(code);
            lexer.Scan();

            Console.ReadKey();

        }
    }
}
