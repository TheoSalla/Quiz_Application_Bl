using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClient_tutorial
{
    public class RestClient
    {
        HttpClient client = new();

        public Stream GetData(Category catgory,Difficulty difficulty, int amount = 2)
        {
            var route = $"?amount={amount}&category={(int)catgory}&difficulty={difficulty}";
            client.BaseAddress = new Uri($"https://opentdb.com/api.php{route}");
            var response = client.GetStreamAsync(client.BaseAddress).Result;
            return response;
        }

    }
}