using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLexer
{
    class WhitespaceState : State 
    {
        public WhitespaceState() : base()
        {
            addRule((int)' ', States.Whitespace);
        }
    }
}
