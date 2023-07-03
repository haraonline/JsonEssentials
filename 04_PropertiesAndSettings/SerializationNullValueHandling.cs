using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PropertiesAndSettings
{
    internal class SerializationNullValueHandling
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** Serialization Handling Null Values***");
            Console.WriteLine();

            Author hara = new Author
            {
                name = "Hara",
                happy = true,
            };

            // serialize without any null-value handling settings
            Console.WriteLine("Serialize without any null-value handling settings");
            Console.WriteLine("---------------------------------------------------");
            JsonSerializerSettings noNullsettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };
            string json = JsonConvert.SerializeObject(hara, noNullsettings);
            Console.WriteLine(json);

            // serialize with NullValueHandling set to Ignore
            Console.WriteLine("Serialize with NullValueHandling set to Ignore");
            Console.WriteLine("-----------------------------------------------");
            JsonSerializerSettings ignoreNullsettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            };
            json = JsonConvert.SerializeObject(hara, ignoreNullsettings);
            Console.WriteLine(json);

        }
    }
}
