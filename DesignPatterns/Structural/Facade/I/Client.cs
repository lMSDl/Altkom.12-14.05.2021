using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Facade.I
{
    public class Client
    {
        public static void Execute()
        {
            var item = new Person { Name = "Ewa Ewowska", Age = 32 };

            /*var settings = new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore,
                DateFormatString = "yy MMM d",
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            var json = JsonConvert.SerializeObject(item, settings);*/

            var json = JsonFacade.Serialize(item);
            item = JsonFacade.Deserialize<Person>(json);
        }
    }
}
