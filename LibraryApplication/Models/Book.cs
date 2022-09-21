using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication.Models
{
    public class Book:BaseEntity
    {
        public int PageCount { get; set; }
        public Author Author { get; set; }
        public Book(string name,int pageCount)
        {
            Name = name;
            PageCount = pageCount;
            SoftDelete = false;
        }
    }
}
