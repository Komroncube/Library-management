using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management
{
    public class Book
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public Guid? ReaderID { get; set; }
        public Book(string name, string description, string author)
        {
            ID= Guid.NewGuid();
            Name=name;
            Description=description;
            Author = author;
        }
    }
}
