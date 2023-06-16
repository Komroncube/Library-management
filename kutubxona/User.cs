using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library_management
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        public User(string firstName, string lastName)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
        }
        public User(string firstName, string lastName, string username):this(firstName, lastName)
        {
            UserName= username;
        }
        public override string ToString()
        {
            return $"Kitob" +
            $"\nid: {Id}" +
                $"\nFirstName: {FirstName}" +
                $"\nNLastName: {LastName}" +
                $"\nUserName: {UserName}";
        }
    }
}
