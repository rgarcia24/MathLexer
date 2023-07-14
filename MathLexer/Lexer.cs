using System;
using System.Collections.Generic;


namespace MathLexer
{
    public class Lexer
    {
        string source;
        int position;
        StateTables stateTables;


        public Lexer(string code)
        {
            position = 0;
            source = code;
            stateTables = new StateTables();
            
        }
       


        public void  Scan()
        {
            string token = "";
            State currentState = stateTables.startState;
            while (position < source.Length && !currentState.Stop)
            {
                char c = source[position];
                currentState = currentState.transition[(int)c];
                States stateTest = currentState.transition[(int)c];



                Console.WriteLine(c);
                Console.WriteLine(stateTest);
                position++;
            }
            //while my input is not EOF AND !CURRENTSTATE.STOP 
                // GET CHARACTER: char c = source[position++]
                // GET A CHARACTER, CURRENTSTATE = CURRENTSTATE.TRANSITION[C]
            // EITHER CURRENTSTATE.ACCEPT == TRUE WHICH MEANS VALID TOKEN
            // OTHERWISE CURRETNSTATE.FALSE == FALSE WHICH MEANS CHAR CANNOT BE RECOGNIZE
        

         
        }
    }

}