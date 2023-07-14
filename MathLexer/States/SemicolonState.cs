using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLexer
{
    class SemicolonState : State
    {
        public SemicolonState() : base()
        {
            addRule((int)';', States.Semicolon);
        }
    }
}
