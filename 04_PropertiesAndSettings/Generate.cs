using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PropertiesAndSettings
{
    internal class Generate
    {
        public static string ExtendedSingleJson()
        {
            return File.ReadAllText("AuthorSingleExtended.json");
        }
    }
}
