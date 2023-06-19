using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SerializeDeserialize
{
    internal class SerializeDeserializeDemo
    {
        public static void Show()
        {
            string jsonSample = Generate.SingleJson();
            Console.WriteLine("Step 1: output JSON");
            Console.WriteLine(jsonSample);
            Console.WriteLine("----------------------");

            Console.WriteLine("Step 2: Output a class properties using Deserialization");
            Author? author = JsonConvert.DeserializeObject<Author>(jsonSample);
            Console.WriteLine(author.Name);
            Console.WriteLine(author.since);
            Console.WriteLine(author.happy);
            Console.WriteLine(author.issues); //null
            Console.WriteLine(author.car);            
            Console.WriteLine(string.Join(",", author.Courses));
            Console.WriteLine("----------------------");
        }
    }
}
