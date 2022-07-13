using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HttpClient_tutorial
{
    public class NamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            name = Regex.Replace(name, @"(?<=[a-z])([A-Z])", @"_$1").ToLower();
            return name;
       
        }

    }

}