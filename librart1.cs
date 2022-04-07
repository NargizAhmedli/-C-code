using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    internal class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        List<Book> Books { get; set; } = new List<Book>();   
        public void AddBook(Book book)
        {
            Books.Add(book);
        }

    public Book GetBookById(int id)
        {
            return Books.Find(b=>b.Id == Id);
        }
    public void RemoveBook(int id)
    {
        Books.Remove(Books.Find(b=>b.Id == id));       
    }
        
    }
}
