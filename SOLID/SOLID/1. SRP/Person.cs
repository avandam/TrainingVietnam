using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1._SRP
{
    class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public List<Person> GetAllPersons()
        {
            return null;
        }

        public void CreateNewPerson(Person person)
        {

        }

        public void ChangeName(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
