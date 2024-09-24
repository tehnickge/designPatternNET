using designPatternNET.FactoryMethods;

void CheckMsg(string msg)
{
    switch(msg)
    {
        case "1": // данная ситуация демонстрирует возможность хранения разных классов в одном контейнере и демонстрирует патерн - фабричный метод
            List<IPerson> persons = new List<IPerson>();
            FactoryPerson factoryPersons = new FactoryPerson();
            for(int i = 0; i < 5; i++) { persons.Add(factoryPersons.FactoryMethod("name", "age")); }
            foreach(var p in persons) { Console.WriteLine(p.Name); }
            break;
    }
}



string msg = Console.ReadLine();
while (msg != null)
{
    CheckMsg(msg);
    msg = Console.ReadLine();
}
