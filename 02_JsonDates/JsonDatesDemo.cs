using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace _02_JsonDates
{
    internal class JsonDatesDemo
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("*** Json Dates ***");
            Console.WriteLine("----------------------");

            List<DateTime> dates = new List<DateTime>()
            {
                new DateTime(2023,06,22,13,37,25),
                DateTime.Now,
                new DateTime(637143211000000000)
            };

            Console.WriteLine("serialize dates without any dateformat (default):");
            string dateDefault = JsonConvert.SerializeObject(dates, Formatting.Indented);
            Console.WriteLine(dateDefault);
            Console.WriteLine("----------------------");

            // From Json.NET 4.5 and onwards dates are written using the ISO 8601            
            Console.WriteLine("- Serialize object specifying to use Iso DateTime converter");
            string dateIso8601 = JsonConvert.SerializeObject(dates, Formatting.Indented, new IsoDateTimeConverter());
            Console.WriteLine(dateIso8601);
            Console.WriteLine("----------------------");

            Console.WriteLine("- Serialize object specifying Microsoft Date - Default pre .NET 4.5");
            JsonSerializerSettings settingsMicrosoftDate = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            };

            string dateMicrosoftOldDefault = JsonConvert.SerializeObject(
                dates,
                Formatting.Indented,
                settingsMicrosoftDate
            );
            Console.WriteLine(dateMicrosoftOldDefault);
            Console.WriteLine("----------------------");


            Console.WriteLine("- Serialize object specifying custom date format");
            JsonSerializerSettings settingsCustomDate = new JsonSerializerSettings
            {
                DateFormatString = "dd.MM.yyyy hh:mm:ss"
            };

            string dateCustom = JsonConvert.SerializeObject(dates, Formatting.Indented, settingsCustomDate);
            Console.WriteLine(dateCustom);
            Console.WriteLine("----------------------");


            Console.WriteLine("- Serialize object specifying to use the JavaScript DateTime converter");
            string dateJavaScript = JsonConvert.SerializeObject(
                dates,
                Formatting.Indented,
                new JavaScriptDateTimeConverter()
            );
            Console.WriteLine(dateJavaScript);
            Console.WriteLine("----------------------");

            Console.WriteLine("- Serialize object specifying to use the UnixDateTimeConverter DateTime converter");
            string dateUnixDateTimeConverter = JsonConvert.SerializeObject(
                dates,
                Formatting.Indented,
                new UnixDateTimeConverter()
            );
            Console.WriteLine(dateUnixDateTimeConverter);
        }
    }
}
