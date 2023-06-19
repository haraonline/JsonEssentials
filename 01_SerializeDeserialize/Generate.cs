namespace _01_SerializeDeserialize
{
    internal class Generate
    {
        public static string SingleJson()
        {
            return File.ReadAllText("JsonFiles\\AuthorSingle.json");
        }
    }
}
