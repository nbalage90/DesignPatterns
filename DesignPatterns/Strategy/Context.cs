using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Context
    {
        IChoice choice;

        public void SetChoice(IChoice choice)
        {
            this.choice = choice;
        }

        public void ShowChoice()
        {
            choice.MyChoice();
        }
    }
}
