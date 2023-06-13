using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExampleClassLibrary.Helper
{
    internal static class ObjectHelper
    {
        public static T? DeepClone<T>(this T a)
        {
            if (a == null)
            {
                return default;
            }   
            //var options = new JsonSerializerOptions
            //{
            //    IgnoreNullValues = true
            //};

            var serializedObj = JsonSerializer.Serialize(a);
            return JsonSerializer.Deserialize<T>(serializedObj);
        }
    }
}
