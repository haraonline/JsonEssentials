using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PropertiesAndSettings
{
    public class Author
    {
        public Author()
        {
            courses = new List<string> { "course 1", "course 2", "course 3" };
        }

        public string name { get; set; }

        public List<string> courses { get; set; }

        public DateTime since { get; set; }

        public bool happy { get; set; }

        public object issues { get; set; }

        public List<Author> favoriteAuthors { get; set; }

        Car car { get; set; }
    }
}
