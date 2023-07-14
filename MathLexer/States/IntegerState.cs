using System;

namespace MathLexer
{
    class IntegerState : State
    {
        public IntegerState() : base()
        {
            addRule((int)'0', States.Integer);
            addRule((int)'1', States.Integer);
            addRule((int)'2', States.Integer);
            addRule((int)'3', States.Integer);
            addRule((int)'4', States.Integer);
            addRule((int)'5', States.Integer);
            addRule((int)'6', States.Integer);
            addRule((int)'7', States.Integer);
            addRule((int)'8', States.Integer);
            addRule((int)'9', States.Integer);
        }
    }
}
