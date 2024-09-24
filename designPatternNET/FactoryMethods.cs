using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatternNET.FactoryMethods
{
    //абстрактный класс 
    abstract class IPerson
    {
        public IPerson(string name, string age)
        {
            Name = name;
            Age = age;
        }
        public abstract string Name { get; set; }
        public abstract string Age { get; set; }
    }


    //интерфейс содержащий метод (FactoryMethod) возращающий объект нового класса
    interface IFactoryPerson
    {
        public IPerson FactoryMethod(string name, string age); 
    }

    class Person : IPerson
    {
        public Person(string name, string age) : base(name, age) { }
        public override string Name { get; set; }
        public override string Age { get; set; }

    }

    class FactoryPerson : IFactoryPerson 
    {
        public IPerson FactoryMethod(string name, string age)
        {
            return new Person(name, age);
        }
    }
}
