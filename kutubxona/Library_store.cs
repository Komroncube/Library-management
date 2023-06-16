using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management
{
    public class Library_store
    {
        public List<Book> Books { get; set; }
        public List<User> Users { get; set; }

        public Library_store() 
        {
            Books = new List<Book>();
            Users = new List<User>();
        }
        public Library_store(List<Book> books, List<User> users) 
        {
            Books = books;
            Users = users;
            
        }
    }
}
