using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    public class JsonPolicySerializer
    {
        public Policy GetPolicyFromJsonString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Policy>(jsonString,
                new StringEnumConverter());
        }
    }
}
