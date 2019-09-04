using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class ConcreteMediator : IMediator
    {
        List<Friend> participants = new List<Friend>();

        public void Register(Friend friend)
        {
            participants.Add(friend);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("At present, registered Participants are:");
            foreach (Friend friend in participants)
            {
                Console.WriteLine($"{friend.Name}");
            }
        }

        public void Send(Friend friend, string msg)
        {
            if (participants.Contains(friend))
            {
                Console.WriteLine($"[{friend.Name}] posts: {msg}, Last message posted {DateTime.Now}");
                System.Threading.Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine($"An outsider named {friend.Name} trying to send some messages");
            }
        }
    }
}
