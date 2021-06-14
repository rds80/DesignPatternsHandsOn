using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public class SimpleFactory1 : SimpleFactory
    {
        public override IAnimal CreateAnimal()
        {
            IAnimal intendedAnimal = null;
            Console.WriteLine("Enter your choice (0 for Dog, 1 for Tiger)");
            
            string b1 = Console.ReadLine();
            int input;
            
            if (int.TryParse(b1, out input))
            {
                Console.WriteLine("You have entered {0}", input);

                switch(input)
                {
                    case 0:
                        intendedAnimal = new Dog();
                        break;
                    case 1:
                        intendedAnimal = new Tiger();
                        break;
                    default:
                        Console.WriteLine("You must enter either 0 or 1");
                        throw new ApplicationException($"Uknown animal cannot be instantiated");
                }
            }
            return intendedAnimal;
        }
    }
}
