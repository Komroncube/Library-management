using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management
{
    public class LibraryManagement : lib_management_core
    {
        private EmailService emailservice;
        public LibraryManagement()
        {
            emailservice = new EmailService();
        }
        public void RegisterUser(string firstName, string lastName)
        {
            ;
        }
        public void RegisterUser(string firstName, string lastName, string email)
        {
            var founduser = false;
            foreach (var user in Store.Users)
            {
                if (user.Email == email)
                {
                    founduser = true;
                    break;
                }
            }
            if (founduser)
            {
                return;
            }
            Store.Users.Add(new User(firstName, lastName, email));
            emailservice.SendEmail(email);
        }
    }
}
