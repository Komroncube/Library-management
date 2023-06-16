using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Person
    {
        public Person(int age, string name) 
        {
            this.Age = age;
            this.Name = name;
        }
        public int Age { get; set; }
        public string Name { get; set; }
        public void Sozlashish()
        {
            Console.WriteLine("Abs");
        }

    }
}
