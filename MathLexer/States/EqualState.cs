using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLexer
{
    class EqualState : State
    {
        public EqualState() : base()
        {
            addRule((int)'=', States.Equals);
        }
    }
}
