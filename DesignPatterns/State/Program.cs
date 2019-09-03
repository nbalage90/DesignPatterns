using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***State Pattern Demo***\n");
            TV tv = new TV();
            Console.WriteLine("User is pressing buttons in the following sequence:");
            Console.WriteLine("Off->Mute->On->On->Mute->Mute->Off\n");
            tv.PressOffButton();
            tv.PressMuteButton();
            tv.PressOnButton();
            tv.PressOnButton();
            tv.PressMuteButton();
            tv.PressMuteButton();
            tv.PressOffButton();
        }
    }
}
