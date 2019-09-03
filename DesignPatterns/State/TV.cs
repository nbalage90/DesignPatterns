using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class TV
    {
        private IPossibleStates currentState;

        public IPossibleStates CurrentState
        {
            get { return currentState; }
            set { currentState = value; }
        }

        public TV()
        {
            this.currentState = new Off(this);
        }

        public void PressOffButton()
        {
            currentState.PressOffButton(this);
        }

        public void PressOnButton()
        {
            currentState.PressOnButton(this);
        }

        public void PressMuteButton()
        {
            currentState.PressMuteButton(this);
        }
    }
}
