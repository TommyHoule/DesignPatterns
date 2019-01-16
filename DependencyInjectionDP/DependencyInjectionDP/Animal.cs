using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionDP
{
    /*
        using heritage for class Cat vs dependency injection for class Dog
         */
    class Animal
    {
        protected int _age;
        protected string _name;

        //---DI pattern methods
        public void setAnimalName(string name)
        {
            _name = name;
        }

        public void setAnimalAge(int age)
        {
            _age = age;
        }

        public string getAnimalName()
        {
            return _name;
        }

        public int getAnimalAge()
        {
            return _age;
        }

        //---heritage methods
        protected string getAnimalNameH()
        {
            return _name;
        }

        protected int getAnimalAgeH()
        {
            return _age;
        }
    }
}
