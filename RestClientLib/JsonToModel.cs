using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace RestClientLib
{
    public class JsonToModel : IJsonToModel
    {
        public Questions GetQuestions(Category category , Difficulty difficulty, int amount)
        {
            RestClient client = new();
            var data = client.GetData(category, difficulty, amount);

            JsonSerializerOptions serializerOptions = new()
            {
                PropertyNamingPolicy = new NamingPolicy()
            };
            Questions? questions = new();
            try
            {
                questions = JsonSerializer.DeserializeAsync<Questions>(data, serializerOptions).Result;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error message: " + ex.Message);
            }

            //Decode.DecodeJson(q1);
            questions.DecodeText();

            return questions;

        }
    }
}