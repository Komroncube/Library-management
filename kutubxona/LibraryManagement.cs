using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management
{
    public class LibraryManagement : lib_management_core
    {
        public void RegisterUser(string firstName, string lastName)
        {
            
        }
        public void RegisterUser(string firstName, string lastName, string username)
        {
            var founduser = false;
            foreach (var user in Store.Users)
            {
                if (user.UserName == username)
                {
                    founduser = true;
                    break;
                }
            }
            if (founduser)
            {
                return;
            }
            Store.Users.Add(new User(firstName, lastName, username));
        }
    }
}
