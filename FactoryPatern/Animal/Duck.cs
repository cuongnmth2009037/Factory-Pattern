using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatern.Animal
{
    class Duck : IAnimal
    {
        public string GetName()
        {
            return "I am Duck";
        }
    }
}
