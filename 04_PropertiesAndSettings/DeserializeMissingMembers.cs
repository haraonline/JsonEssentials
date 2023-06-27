using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace _04_PropertiesAndSettings
{
    internal class DeserializeMissingMembers
    {
        public static void Show()
        {
            Console.WriteLine("Deserialize Missing Members");
            string xavierJsonExtraNameValue = Generate.ExtendedSingleJson();

            Console.WriteLine("Deserialize with no settings");
            Author xavierAuthor = JsonConvert.DeserializeObject<Author>(xavierJsonExtraNameValue);
        }
    }
}