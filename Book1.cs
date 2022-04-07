using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp32
{
    internal class Book
    {
        private static int _id;
        public Book()
        {
            _id++;
            Id = _id;
        }
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string AuthorName { get; set; }  
        public double Price { get; set; }  
        public string ShowInfo()
        {
             return $"Id: {Id}- Name:{Name} - Price: {Price} - AuthorName: {AuthorName}";
        }
    }
}
