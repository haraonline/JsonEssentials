using Newtonsoft.Json;

namespace _01_SerializeDeserialize
{
    internal class SerializeObjectsDemo
    {
        //serilize different .NET objects to JSON text
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** Serialize different .NET objects to JSON text ***");
            Console.WriteLine();

            Author hara = new Author
            {
                Name = "Hara Kovvali",
                Courses = new string[] { "C#", "RPA", "JavaScript" },
                happy = true
            };

            Console.WriteLine("Serialize a class to JSON text:");
            Console.WriteLine("-------------------------------");
            string objectSerialized = JsonConvert.SerializeObject(hara, Formatting.Indented);
            Console.WriteLine(objectSerialized);


            Console.WriteLine();
            Console.WriteLine("Serialize a C# array to JSON text:");
            Console.WriteLine("---------------------------------");
            string[] myArray = new string[] { "C#", "RPA", "JavaScript" };
            string arraySerialized = JsonConvert.SerializeObject(myArray, Formatting.Indented);
            Console.WriteLine(arraySerialized);


            Console.WriteLine();
            Console.WriteLine("Serialize a C# list to JSON text:");
            Console.WriteLine("---------------------------------");
            List<String> myInterests = new List<string> { "Coding", "Photography", "Guitar", "Business" };
            string listSerialized = JsonConvert.SerializeObject(myInterests, Formatting.Indented);
            Console.WriteLine(listSerialized);


            Console.WriteLine();
            Console.WriteLine("Serialize a C# dictionary to JSON text:");
            Console.WriteLine("--------------------------------------");
            Dictionary<string, string> myDictionary = new Dictionary<string, string>
            {
                { "Name", "Hara" },
                { "Age", "30" },
                { "Location", "Hyderabad" }
            };
            string dictionarySerialized = JsonConvert.SerializeObject(myDictionary, Formatting.Indented);
            Console.WriteLine(dictionarySerialized);


            Console.WriteLine();
            Console.WriteLine("Serialize JSON to a File:");
            Console.WriteLine("-------------------------");            
            

            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(basePath, "JsonFiles", "hara.json");
            File.WriteAllText(filePath, JsonConvert.SerializeObject(hara, Formatting.Indented));
            Console.WriteLine($"JSON text is written to {filePath}");
        }
    }
}