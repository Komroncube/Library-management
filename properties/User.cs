using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class User
    {
        public string Name 
        {
            get
            {
                return ism;
            } 
            set 
            {
                ism = value;
            } 
        }
        public int Age
        {
            get {
                return 23;
            }
            
            set
            {
                switch(value)
                {
                    case 54:
                        Console.WriteLine("Kamoliddin");
                        break;
                    default:
                        Console.WriteLine("Yozilmadi");
                        break;
                }
            }
        }
        private string ism;
    }
    public static class ExtensionClass
    {
        public static int Dublicate(this int a)
        {
            return a*a;
        }
        public static string NamePlus(this User a, string b)
        {
            return a.Name+ b;
        }
        public static int Plus(this int a, int b)
        {
            return a + b;
        }
        public static string Plus(this string a, string b)
        {
            return a + b;
        }
    }
}
