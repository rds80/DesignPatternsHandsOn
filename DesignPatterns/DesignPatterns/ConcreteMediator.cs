using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ConcreteMediator : IMediator
    {
        List<Friend> participants = new List<Friend>();
        public void Register(Friend friend) => participants.Add(friend);

        public void Send(Friend friend, string message)
        {
            if (participants.Contains(friend))
            {
                Console.WriteLine($"{friend.Name} posts: {message} " +
                    $"Last message posted {DateTime.Now}");
                System.Threading.Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine($"An outsider named {friend.Name} trying " +
                    $"to send some messages");
            }
        }
    }
}
