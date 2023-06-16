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
        
        public string Author { get; set; }
        public string Category { get; set; }
        public Guid? ReaderID { get; set; }
        public Book(string name, string author)
        {
            ID= Guid.NewGuid();
            Name=name;
            Author = author;
            //ReaderID=Guid.NewGuid();
        }
        public override string ToString()
        {
            return $"Kitob" +
                $"\nid: {ID}"+
                $"\nnomi: {Name}"+
                $"\nMuallif: {Author}" +
                $"\nKim o'qiyapti {ReaderID}";
        }
    }
}
