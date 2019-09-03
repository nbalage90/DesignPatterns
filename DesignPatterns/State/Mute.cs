using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Mute : IPossibleStates
    {
        TV tvContext;

        public Mute(TV context)
        {
            Console.WriteLine("TV is in Mute mode now.");
            this.tvContext = context;
        }

        public void PressOnButton(TV context)
        {
            Console.WriteLine("You pressed On button. Going from Mute mode to On state.");
            tvContext.CurrentState = new On(context);
        }

        public void PressOffButton(TV context)
        {
            Console.WriteLine("You pressed Off button. Going to Mute mode to Off state.");
            tvContext.CurrentState = new Off(context);
        }

        public void PressMuteButton(TV context)
        {
            Console.WriteLine("You pressed Mute button. TV is already in Mute mode.");
        }
    }
}
