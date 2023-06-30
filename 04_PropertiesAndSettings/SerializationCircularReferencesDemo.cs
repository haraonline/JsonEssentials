using Newtonsoft.Json;

namespace _04_PropertiesAndSettings
{
    internal class SerializationCircularReferencesDemo
    {
        public static void Show()
        {
            Console.WriteLine("Circular References");
            Console.WriteLine("---------------------");

            Author xavier = new Author() { name = "Xavier Morera" };
            Author jordi = new Author() { name = "Jordi Torres" };
            Author hara = new Author() { name = "Hara Kovvali" };
            xavier.favoriteAuthors = new List<Author>() { jordi, hara, xavier };

            // Serialize with circular references
            try
            {
                Console.WriteLine("Serialize with circular references");
                string xavierJson = JsonConvert.SerializeObject(xavier);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Serialize ignoring circular references
            try
            {
                Console.WriteLine("Serialize ignoring circular references");
                JsonSerializerSettings settingsIngore = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                };
                string xavierJson = JsonConvert.SerializeObject(xavier, settingsIngore);
                Console.WriteLine(xavierJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Serialize with error on circular references
            try
            {
                Console.WriteLine("Serialize with error on circular references");
                JsonSerializerSettings settingsError = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    ReferenceLoopHandling = ReferenceLoopHandling.Error
                };
                string xavierJson = JsonConvert.SerializeObject(xavier, settingsError);
                Console.WriteLine(xavierJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Serialize with preserve references
            try
            {
                Console.WriteLine("Serialize with preserve references");
                JsonSerializerSettings settingsPreserve = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    PreserveReferencesHandling = PreserveReferencesHandling.All
                };
                string xavierJson = JsonConvert.SerializeObject(xavier, settingsPreserve);
                Console.WriteLine(xavierJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
