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
        public string Email { get; set; }

        private User(string firstName, string lastName)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
        }
        public User(string firstName, string lastName, string email):this(firstName, lastName)
        {
            Email= email;
        }
        public override string ToString()
        {
            return $"User   " +
            $"\nid: {Id}" +
            $"\nFirstName: {FirstName}" +
            $"\nNLastName: {LastName}" +
            $"\nUserName: {Email}";
        }
    }
}
