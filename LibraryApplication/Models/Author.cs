using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication.Models
{
    public class Author:BaseEntity
    {
        public string Surname { get; set; }
        public int Age { get; set; }
        public List<Book> Books { get; set; }




        public Author(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            SoftDelete = false;
            Books = new List<Book>();
        }
    }
}
