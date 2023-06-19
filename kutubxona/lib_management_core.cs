using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management
{
    public abstract class lib_management_core
    {
        public lib_management_core()
        {
            Store = new Library_store();
        }
        public lib_management_core(List<Book> books, List<User> users)
        {
            Store = new Library_store(books, users);

        }
        public Library_store Store { get; set; }
        
        
        public void DisplayAllUsers()
        {
            foreach (User user in Store.Users)
            {
                Console.WriteLine(user.ToString());
            }
        }
        public void DisplayAllBooks()
        {
            foreach(Book book in Store.Books)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }

}
