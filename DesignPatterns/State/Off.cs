using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Off : IPossibleStates
    {
        TV tvContext;

        public Off(TV context)
        {
            Console.WriteLine("TV is Off now.");
            this.tvContext = context;
        }

        public void PressOnButton(TV context)
        {
            Console.WriteLine("You pressed On button. Going from Off to On state");
            tvContext.CurrentState = new On(context);
        }

        public void PressOffButton(TV context)
        {
            Console.WriteLine("You pressed Off button. TV is already in Off state");
        }

        public void PressMuteButton(TV context)
        {
            Console.WriteLine("You pressed Mute button. TV is already in Off state, so Mute operation will not work.");
        }
    }
}
