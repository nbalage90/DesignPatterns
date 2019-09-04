using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class Context
    {
        private int getInput;
        private string getStringInput;
        private string setOutput;
        private bool canProceed = false;

        public bool CanProceed
        {
            get { return canProceed; }
        }

        public int GetInput
        {
            get { return getInput; }
        }

        public string SetOutput
        {
            get { return setOutput; }
            set { setOutput = value; }
        }

        public Context(string input)
        {
            this.getStringInput = input;
        }

        public int ValidateUserInputBeforeProceedings(string inputString)
        {
            if (int.TryParse(inputString, out getInput))
            {
                Console.WriteLine($"You have entered {getInput}");
                if ((getInput < 100) || (getInput > 999))
                {
                    Console.WriteLine("Please enter a number between 100 and 999 and try again.");
                    return -9999;
                }
            }
            canProceed = true;
            return getInput;
        }
    }
}
