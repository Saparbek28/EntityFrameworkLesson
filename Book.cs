using System;

namespace EntityFrameworkLesson
{
    public class Book :Entity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Author Author { get; set; }
    }
}
