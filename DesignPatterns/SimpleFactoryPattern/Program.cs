using System;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Factory Pattern");
            
            IAnimal preferredType = null;
            SimpleFactory simpleFactory = new SimpleFactory1();
            preferredType = simpleFactory.CreateAnimal();

            preferredType.Speak();
            preferredType.Action();
        }
    }
}
