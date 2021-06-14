using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public abstract class SimpleFactory
    {
        public abstract IAnimal CreateAnimal();
    }
}
