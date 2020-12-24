﻿using BookShop.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Entities.Concrete
{
    public class Book : IEntity // Book bir tabloyu temsil eder.
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal UnitPrice { get; set; }
        public Author Author { get; set; }
        public override string ToString() =>
            $"{Id,-5} {Title,-35} {UnitPrice,-5}";
        
    }
}
