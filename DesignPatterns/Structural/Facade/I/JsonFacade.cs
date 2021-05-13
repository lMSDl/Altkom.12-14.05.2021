using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Facade.I
{
    public static class JsonFacade
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings()
        {
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Ignore,
            DateFormatString = "yy MMM d",
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        };

        public static string Serialize<T>(T @object)
        {
            return JsonConvert.SerializeObject(@object, Settings);
        }

        public static T Deserialize<T>(string @string)
        {
            return JsonConvert.DeserializeObject<T>(@string, Settings);
        }
    }
}
