using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class On : IPossibleStates
    {
        TV tvContext;
        public On(TV context)
        {
            Console.WriteLine("TV is On now.");
            this.tvContext = context;
        }

        public void PressOnButton(TV context)
        {
            Console.WriteLine("You pressed On button. TV is already in On state.");
        }

        public void PressOffButton(TV context)
        {
            Console.WriteLine("You pressed Off button. Going from On to Off state.");
            tvContext.CurrentState = new Off(context);
        }

        public void PressMuteButton(TV context)
        {
            Console.WriteLine("You pressed Mute button. Going from On to Mute mode.");
            tvContext.CurrentState = new Mute(context);
        }
    }
}
