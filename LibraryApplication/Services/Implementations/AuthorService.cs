using LibraryApplication.Data;
using LibraryApplication.Models;
using LibraryApplication.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryApplication.Services.Implementations
{
    public class AuthorService : ILibraryService<Author>
    {
        private Library<Author> library;
        public AuthorService()
        {
            library = new Library<Author>();
        }

        public void Create(Author entity)
        {
            library.Datas.Add(entity);
        }

        public void Delete(string name)
        {
            Author author = library.Datas.Find(x=>x.Name.ToLower().Trim()==name.ToLower().Trim());
            
            author.SoftDelete = true;
            GetAll();
        }

        public void Get(string filter)
        {
            try
            {
                Author author = library.Datas.Find(m => m.Name.Contains(filter.ToLower().Trim())
                ||
                m.Surname.Contains(filter.ToLower().Trim()));

                Console.WriteLine(author.Name + " " + author.Surname);
            }
            catch (Exception)
            {
                Console.WriteLine("Author not found");
            }
        }

        public void GetAll()
        {
            foreach (var author in library.Datas.Where(m=>m.SoftDelete==false))
            {               
                Console.WriteLine(author.Name+" "+author.Surname);
            }
        }
    }
}
