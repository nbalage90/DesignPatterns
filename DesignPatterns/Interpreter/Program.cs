using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Interpreter Pattern Demo***\n");
            string inputString;
            Console.WriteLine("Enter a 3 digit number only (i.e. 100 to 999)");
            inputString = Console.ReadLine();
            Context context = new Context(inputString);
            if (context.ValidateUserInputBeforeProceedings(inputString) != -999)
            {
                List<InputExpression> expTree = new List<InputExpression>();
                expTree.Add(new HundredExpression());
                expTree.Add(new TensExpression());
                expTree.Add(new UnitExpression());
                foreach (InputExpression inputExpression in expTree)
                {
                    inputExpression.Interpret(context);
                }
                Console.WriteLine($"Original Input {context.GetInput} is interpreted as {context.SetOutput}");
            }
        }
    }
}
