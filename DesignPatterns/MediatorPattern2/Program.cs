using System;

namespace MediatorPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();

            var amit = new Friend1(mediator, "Amit");
            var sohel = new Friend2(mediator, "Sohel");
            var raghu = new Boss(mediator, "Raghu");

            //Register participants
            mediator.Register(amit);
            mediator.Register(sohel);
            mediator.Register(raghu);

            Console.WriteLine("Communication starts among participants...");
            amit.Send(sohel, $"Hi Sohel, can we discuss the mediator pattern?");
            sohel.Send(amit, $"Hi Amit, we can discuss now");
            raghu.Send(sohel, $"Please get back to work shortly");
            raghu.Send(amit, $"Please get back to work shortly");

            //Changing the status of Sohel
            sohel.Status = "Off";
            //Checking current status
            mediator.DisplayDetails();
            amit.Send(sohel, $"I am testing to send a message when Sohel is on State again");
            amit.Status = "Off";
            mediator.DisplayDetails();

            raghu.Send(amit, "Can you please come here?");
            raghu.Send(sohel, "Can you please come here?");

            //An outsider/unknown person tries to participate
            Unknown unknown = new Unknown(mediator, "Jack");
            unknown.Send(amit, "Hello Amit...");

            //Wait for user
            Console.ReadLine();
        }
    }
}
