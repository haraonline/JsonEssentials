using Newtonsoft.Json;

namespace _01_SerializeDeserialize
{
    internal class ObjectReferencesDemo
    {
        // This class is used to demonstrate how JSON handles object references
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** Object References Demo ***");
            Console.WriteLine();

            Author xavier = new Author()
            {
                Name = "Xavier Morera",
                Courses = new string[] { "Solr", "Spark", "Python" },                
            };

            Author lars = new Author()
            {
                Name = "Lars Klint",
                Courses = new string[] { "Xamarin", "Azure" }
            };

            Author jason = new Author()
            {
                Name = "Jason Roberts",
                Courses = new string[] { "C#", "F#" }
            };

            xavier.favouriteAuthors = new List<Author>() { xavier, lars, jason, jason };
            //string xavierJson = JsonConvert.SerializeObject(xavier);
            //string xavierJson = JsonConvert.SerializeObject(xavier, Formatting.Indented);

            string xavierJson = JsonConvert.SerializeObject(xavier, new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });

            Console.WriteLine(xavierJson);
        }
    }
}
