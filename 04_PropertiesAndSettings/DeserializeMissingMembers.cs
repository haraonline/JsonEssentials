using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace _04_PropertiesAndSettings
{
    internal class DeserializeMissingMembers
    {
        public static void Show()
        {
            Console.WriteLine("Deserialize Missing Members with no settings");
            string xavierJsonExtraNameValue = Generate.ExtendedSingleJson();
            
            Author xavierAuthor = JsonConvert.DeserializeObject<Author>(xavierJsonExtraNameValue);
            Console.WriteLine(xavierAuthor.name);
            Console.WriteLine("---------------------");

            Console.WriteLine("Deserialize Missing Members with MissingMemberHandling.Ignore");
            JsonSerializerSettings jsonSettingsIgnore = new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            Author xavierAuthorIgnore = JsonConvert.DeserializeObject<Author>(xavierJsonExtraNameValue, jsonSettingsIgnore);
            Console.WriteLine(xavierAuthorIgnore.name);
            Console.WriteLine("---------------------");

            try
            {
                Console.WriteLine("Deserialize Missing Members with MissingMemberHandling.Error");
                Author xavierWithSettingsError = JsonConvert.DeserializeObject<Author>(xavierJsonExtraNameValue, new JsonSerializerSettings()
                {
                    Formatting = Formatting.Indented,
                    MissingMemberHandling = MissingMemberHandling.Error
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
}