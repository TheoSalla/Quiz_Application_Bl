using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace HttpClient_tutorial
{
    public class JsonToModel
    {

        public static Questions GetQuestions(Category category, Difficulty difficulty)
        {
            RestClient client = new();
            var data = client.GetData(category, difficulty);

            JsonSerializerOptions serializerOptions = new() 
            {
                PropertyNamingPolicy = new NamingPolicy()
            };
            Questions? q1 = new();
            try
            {
                q1 = JsonSerializer.DeserializeAsync<Questions>(data, serializerOptions).Result;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error message: " + ex.Message);
            }

            //Decode.DecodeJson(q1);
            q1.DecodeJson();

            return q1;

        }
    }
}