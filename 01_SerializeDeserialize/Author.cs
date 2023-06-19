using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace _01_SerializeDeserialize
{
    [JsonObject(IsReference = true)]
    internal class Author
    {
        public string Name { get; set; }
        public string[] Courses { get; set; }
        public DateTime since { get; set; }
        public bool happy { get; set; }
        public object issues { get; set; }
        public Car car { get; set; }
        public List<Author> favouriteAuthors { get; set; }
        public AuthorRelationship authorRelationship { get; set; }        


        //override string ToString()
        public override string ToString()
        {
            return $"Name: {Name}, Courses: {string.Join(", ", Courses)}," +
                $" Since: {since}, Happy: {happy}, Issues: {issues}, Car: {car}," +                
                $"Author Relationship: {authorRelationship}";
        }
    }
}