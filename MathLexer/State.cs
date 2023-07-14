using System;
using System.Collections.Generic;

namespace MathLexer
{
    enum States
    {
        Invalid,
        Start,
        Final,
        Integer,
        Identifier,
        Operator,
        Semicolon,
        Whitespace,
        Equals
        

    }
    abstract class State
    {
        public States[] transition;
        public bool Stop;
        public bool Accept;

        public State()
        {
            Stop = false;
            Accept = false;
            transition = new States[128];
        }

        public void addRule(int c, States state)
        {

            transition[c] = state;
        }

    }

}
