using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern2
{
    public class ConcreteMediator : IMediator
    {
        List<Friend> participants = new List<Friend>();

        public void Register(Friend friend) => participants.Add(friend);

        public void DisplayDetails()
        {
            Console.WriteLine($"At present, registered Participants are:");
            participants.ForEach(friend =>
            {
                Console.WriteLine($"{friend.Name}, {friend.Status}");
            });
        }

        public void Send(Friend fromFriend, Friend toFriend, string message)
        {
            if (participants.Contains(fromFriend))
            {
                if (toFriend.Status == "On")
                {
                    Console.WriteLine($"[{fromFriend.Name}-> {toFriend.Name}" +
                        $" :  {message} Last message posted {DateTime.Now} ");
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine($"[{fromFriend.Name}-> {toFriend.Name}" +
                    $" : {fromFriend.Name} you cannot post messages now." +
                    $"{toFriend.Name} is offline");
                    System.Threading.Thread.Sleep(1000);
                }
            }
            else
            {
                Console.WriteLine($"An outsider named {fromFriend.Name} trying to" +
                    $"send some messages");
            }
        }
    }
}
