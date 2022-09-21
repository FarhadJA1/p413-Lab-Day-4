using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApplication.Models
{
    public class BaseEntity
    {    
        public bool SoftDelete { get; set; }
        public string Name { get; set; }
    }
}
