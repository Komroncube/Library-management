using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class User : Person
    {
        
        public User(int age, string name, int money):base(age, name)
        {
            Money = money;
        }
        public User(int age, string name)
        {
            Age = age;
            Name = name;
        }
        //public User(int age, string name) : base(age, name) { }

        public int Money { get; set; }
        public void Show()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Age);
            Console.WriteLine(this.Money);
        }
    }
}