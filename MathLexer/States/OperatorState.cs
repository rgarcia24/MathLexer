using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLexer
{
    class OperatorState : State
    {
        public OperatorState() : base()
        {
            addRule((int)'+', States.Operator);
            addRule((int)'-', States.Operator);
            addRule((int)'/', States.Operator);
            addRule((int)'*', States.Operator);
            

        }

    }
}
