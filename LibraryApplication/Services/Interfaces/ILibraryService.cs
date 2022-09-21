using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication.Services.Interfaces
{
    public interface ILibraryService<T> where T:BaseEntity
    {
        void Create(T entity);
        void Delete(string name);
        void Get(string filter);
        void GetAll();
      
    }
}
