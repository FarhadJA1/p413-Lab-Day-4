using LibraryApplication.Data;
using LibraryApplication.Models;
using LibraryApplication.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryApplication.Services.Implementations
{
    public class BookService : ILibraryService<Book>
    {
        private Library<Book> library;
        public BookService()
        {
            library = new Library<Book>();
        }

        public void Create(Book entity)
        {
            library.Datas.Add(entity);
        }

        public void Delete(string name)
        {
            Book book = library.Datas.Find(a => a.Name.ToLower().Trim() == name.ToLower().Trim());
            book.SoftDelete = true;
            GetAll();
        }

        public void Get(string filter)
        {
            
                Book book = library.Datas.Find(v => v.Name.ToLower().Trim().Contains(filter.Trim().ToLower())
                || v.Author.Name.ToLower().Trim().Contains(filter.Trim().ToLower()) ||
                v.Author.Surname.ToLower().Trim().Contains(filter.Trim().ToLower()));

                Console.WriteLine(book.Name);
            
            

        }

        public void GetAll()
        {
            foreach (var book in library.Datas.Where(c=>c.SoftDelete==false))
            {               
                Console.WriteLine(book.Author.Name+" "+book.Author.Surname+":"+book.Name);
            }
        }
    }
}
