using System;

namespace Class3_Assignment3_BasicDefinitions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Definitions");
            /*Statement: A complete "thought" in code. Ends with semi-colon. Typically,
             equivalent to one line of code.*/
            Console.WriteLine("This hard-coded text could not have been printed if it " +
                "was not coded as a statement using the WriteLine method.");
            Console.ReadLine();

            /*Expression: A part of a statement in code. Made up of one or more
             * operators and operands.*/
            int x = 4;
            int y = 6;
            int z = (4 * (x + y))/2;

            Console.WriteLine(z);
            Console.ReadLine();

            /*Operator: Acts on operands to perform and action.*/
            string operatorExample = "operator";
            string operatorUpper = operatorExample.ToUpper();

            Console.WriteLine(operatorUpper);
            Console.ReadLine();

            /*Operand: The "nouns" of code statements. They include, but are not limited  
             * to classes and variables.*/

            string operandExample = "operand";
            Console.WriteLine(operandExample);
            Console.ReadLine();
        }
    }
}
