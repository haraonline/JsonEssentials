using Newtonsoft.Json;

namespace _01_SerializeDeserialize
{
    internal class DeserializeObjectsDemo
    {
        //deserialize - from Json Text to .NEt objects

        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** Deserialize JSON to .NET Objects ***");

            string jsonAuthor = 
                @"{                   
                   'name': 'Hara',
                   'Courses': ['how to die peacefully', 'how to be normal', 'getting that thing ...'],
                   'happy': true,
                   'issues': null,        
                   'car': {'model': 'BMW', 'year': 2010},                   
                   'authorRelationship': 2,
                 }";                

            Console.WriteLine("Json object to a class");
            Author? author = JsonConvert.DeserializeObject<Author>(jsonAuthor);
            Console.WriteLine(author?.ToString());
        }
    }
}