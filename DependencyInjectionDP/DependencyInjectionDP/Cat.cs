using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDP
{
    class Cat : Animal
    {
        public Cat()
        {
        }

        public Cat(string name)
        {
            _name = name;
        }

        public Cat(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string getCatName()
        {
            return base.getAnimalNameH();
        }

        public int getCatAge()
        {
            return base.getAnimalAgeH();
        }
    }
}
