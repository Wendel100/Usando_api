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

    public partial class Welcome
    {
        public static Dictionary<string, Welcome> FromJson(string json) => JsonConvert.DeserializeObject<Dictionary<string, Welcome>>(json, QuickType.Converter.Settings);
    }
}

