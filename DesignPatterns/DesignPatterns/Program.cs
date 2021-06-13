using MediatorPattern;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Mediator Paterrn");

            var mediator = new ConcreteMediator();

            var amit = new Friend1(mediator, "Amit");
            var sohel = new Friend2(mediator, "Sohel");
            var raghu = new Boss(mediator, "Raghu");

            //Register participants
            mediator.Register(amit);
            mediator.Register(sohel);
            mediator.Register(raghu);

            Console.WriteLine("Communication starts among participants...");
            amit.Send($"Hi Sohel, can we discuss the mediator pattern?");
            sohel.Send($"Hi Amit, we can discuss now");
            raghu.Send($"Please get back to work shortly");

            //An outsider/unknown person tries to participate
            //without getting registered
            var unknown = new Unknown(mediator, "Jack");
            unknown.Send("Hello guys...");

            //Wait for user
            Console.Read();
        }
    }
}
