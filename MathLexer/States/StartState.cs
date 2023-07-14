using System;


namespace MathLexer
{
    class StartState : State
    {
        public StartState() : base()
        {
            addRule((int)'a', States.Identifier);
            addRule((int)'b', States.Identifier);
            addRule((int)'c', States.Identifier);
            addRule((int)'d', States.Identifier);
            addRule((int)'e', States.Identifier);
            addRule((int)'f', States.Identifier);
            addRule((int)'g', States.Identifier);
            addRule((int)'h', States.Identifier);
            addRule((int)'i', States.Identifier);
            addRule((int)'j', States.Identifier);
            addRule((int)'k', States.Identifier);
            addRule((int)'l', States.Identifier);
            addRule((int)'m', States.Identifier);
            addRule((int)'n', States.Identifier);
            addRule((int)'o', States.Identifier);
            addRule((int)'p', States.Identifier);
            addRule((int)'q', States.Identifier);
            addRule((int)'r', States.Identifier);
            addRule((int)'s', States.Identifier);
            addRule((int)'t', States.Identifier);
            addRule((int)'u', States.Identifier);
            addRule((int)'v', States.Identifier);
            addRule((int)'w', States.Identifier);
            addRule((int)'x', States.Identifier);
            addRule((int)'y', States.Identifier);
            addRule((int)'z', States.Identifier);
            addRule((int)'A', States.Identifier);
            addRule((int)'B', States.Identifier);
            addRule((int)'C', States.Identifier);
            addRule((int)'D', States.Identifier);
            addRule((int)'E', States.Identifier);
            addRule((int)'F', States.Identifier);
            addRule((int)'G', States.Identifier);
            addRule((int)'H', States.Identifier);
            addRule((int)'I', States.Identifier);
            addRule((int)'J', States.Identifier);
            addRule((int)'K', States.Identifier);
            addRule((int)'L', States.Identifier);
            addRule((int)'M', States.Identifier);
            addRule((int)'N', States.Identifier);
            addRule((int)'O', States.Identifier);
            addRule((int)'P', States.Identifier);
            addRule((int)'Q', States.Identifier);
            addRule((int)'R', States.Identifier);
            addRule((int)'S', States.Identifier);
            addRule((int)'T', States.Identifier);
            addRule((int)'U', States.Identifier);
            addRule((int)'V', States.Identifier);
            addRule((int)'W', States.Identifier);
            addRule((int)'X', States.Identifier);
            addRule((int)'Y', States.Identifier);
            addRule((int)'Z', States.Identifier);


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


            addRule((int)'+', States.Operator);
            addRule((int)'-', States.Operator);
            addRule((int)'/', States.Operator);
            addRule((int)'*', States.Operator);
            

            addRule((int)'=', States.Equals);

            addRule((int)' ', States.Whitespace);

            addRule((int)';', States.Semicolon);





        }
    }
}
