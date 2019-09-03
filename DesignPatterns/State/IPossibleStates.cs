using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    interface IPossibleStates
    {
        void PressOnButton(TV context);
        void PressOffButton(TV context);
        void PressMuteButton(TV context);
    }
}
