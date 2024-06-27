//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var welcome = Welcome.FromJson(jsonString);

namespace QuickType
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public static class Serialize
    {
        public static string ToJson(this Dictionary<string, Welcome> self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }
}

