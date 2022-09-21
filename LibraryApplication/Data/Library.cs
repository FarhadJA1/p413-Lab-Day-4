using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication.Data
{
    public class Library<T>
    {
        public List<T> Datas { get; set; }
        public Library()
        {
            Datas = new List<T>();
        }
        
    }
}
