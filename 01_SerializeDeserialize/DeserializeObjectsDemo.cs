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
            Console.WriteLine();

            string jsonAuthor = 
                @"{                   
                   'name': 'Hara',
                   'Courses': ['world view', 'how to be normal', 'getting that thing ...'],
                   'happy': true,
                   'issues': null,        
                   'car': {'model': 'BMW', 'year': 2010},                   
                   'authorRelationship': 2,
                 }";                

            Console.WriteLine("Json object to a class");
            Console.WriteLine("-----------------------");
            Author? authorClass = JsonConvert.DeserializeObject<Author>(jsonAuthor);
            Console.WriteLine(authorClass?.ToString());

            Console.WriteLine();
            Console.WriteLine("Json object to a var");
            Console.WriteLine("-----------------------");
            var authorVar = JsonConvert.DeserializeObject(jsonAuthor);
            Console.WriteLine(authorVar?.ToString());

            Console.WriteLine();
            Console.WriteLine("Deserialize into an anonymous .NET type");
            Console.WriteLine("-----------------------");
            var authorAnonymousDefinition = new
            {
                name = "",
                Courses = new string[] { "" },
                happy = false,
                issues = (string?)null,
                car = new { model = "", year = 0 },
                authorRelationship = 0
            };

            var authorAnonymous = JsonConvert.DeserializeAnonymousType(jsonAuthor, authorAnonymousDefinition);
            Console.WriteLine(authorAnonymous?.ToString());


            Console.WriteLine();
            Console.WriteLine("Deserialize a json array to a .NET List");
            Console.WriteLine("-----------------------");
            string jsonCollection = @"['house of cards', 'narcos', 'the big bang theory']";
            List<string>? collection = JsonConvert.DeserializeObject<List<string>>(jsonCollection);
            Console.WriteLine(string.Join(", ", collection));


            Console.WriteLine();
            Console.WriteLine("Deserialize a json object to a .NET Dictionary");
            Console.WriteLine("-----------------------");
            string jsonDictionary = @"{'name': 'Hara', 'age': 30, 'happy': true}";
            Dictionary<string, object>? authorDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonDictionary);
            Console.WriteLine(string.Join(", ", authorDict.Select(x => $"{x.Key}: {x.Value}")));


            Console.WriteLine();
            Console.WriteLine("Deserialize a json file into a .NET Object");
            Console.WriteLine("-----------------------");
            //read json from the folder JsonFiles
            string jsonFile = File.ReadAllText(@"JsonFiles\AuthorSingle.json");
            Author? authorFromFile = JsonConvert.DeserializeObject<Author>(jsonFile);
            Console.WriteLine(authorFromFile.Name);
            



        }
    }
}