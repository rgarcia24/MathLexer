
namespace MathLexer
{
    class StateTables
    {
        public State startState;
        public State integerState;
        public State operatorState;
        public State identifierState;
        public State equalState;
        public State semicolonState;
        public State whitespaceState;

        public StateTables()
        {
            startState = new StartState();
            integerState = new IntegerState();
            operatorState = new OperatorState();
            identifierState = new IdentifierState();
            equalState = new EqualState();
            semicolonState = new SemicolonState();
            whitespaceState = new WhitespaceState();

        }
    }

}
