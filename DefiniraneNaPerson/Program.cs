using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiniraneNaPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Georgi", 20);
            Person person2 = new Person("Ivanka", 25);
            Person person3 = new Person("Ivan", 30);
            Console.WriteLine(Person.Counter);
        }
    }
}
