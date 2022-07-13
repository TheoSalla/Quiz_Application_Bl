

using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Text.Unicode;
using HttpClient_tutorial;


Questions questions = JsonToModel.GetQuestions(Category.history, Difficulty.easy);

int count = 1;
foreach(var item in questions.Results)
{
    Console.WriteLine($"Questin {count}");
    Console.WriteLine(item.Question);
    Console.WriteLine($"Answer: {item.CorrectAnswer}");
    Console.WriteLine("Wrong answers: ");
    foreach(var ic in item.Incorrect_Answers)
    {
        Console.WriteLine(ic);
    }
    count++;
}


// HttpClient client = new();
// client.BaseAddress = new Uri("https://opentdb.com/api.php?amount=10&category=18");

// var response = await client.GetStreamAsync(client.BaseAddress);



// var serializerOptions = new JsonSerializerOptions
// {
//     Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
//     PropertyNamingPolicy = new NamingPolicy()
// };


// Questions? q1 = new();

// try
// {
//     q1 = await JsonSerializer.DeserializeAsync<Questions>(response, serializerOptions);
// }
// catch (System.Exception ex)
// {

//     Console.WriteLine("Error message: " + ex.Message);
// }


// foreach (var item in q1.Results)
// {
//     System.Console.WriteLine(System.Web.HttpUtility.HtmlDecode(item.Question));
// }




// HttpClient client = new HttpClient();
// HttpResponseMessage response = await client.GetAsync("https://opentdb.com/api_count.php?category=12");


// var serialzeOptions = new JsonSerializerOptions
// {
//         //PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
//       PropertyNamingPolicy = new NamingPolicy()

// };

// string json = await response.Content.ReadAsStringAsync();

// Category category = new();
// try
// {
//     category = JsonSerializer.Deserialize<Category>(json, serialzeOptions);
// }
// catch (System.Text.Json.JsonException ex)
// {
//     Console.WriteLine($"Error message: {ex.Message}");
// }


// Console.WriteLine(category.CategoryId);

// Console.WriteLine(category.CategoryQuestionCount.TotalQuestionCount);
// Console.WriteLine(category.CategoryQuestionCount.TotalEasyQuestionCount);
// Console.WriteLine(category.CategoryQuestionCount.TotalHardQuestionCount);
// Console.WriteLine(category.CategoryQuestionCount.TotalQuestionCount);





// HttpResponseMessage response2 = await client.GetAsync("https://opentdb.com/api_category.php");