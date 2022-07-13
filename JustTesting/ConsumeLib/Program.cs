// See https://aka.ms/new-console-template for more information
using RestClientLib;


Console.WriteLine("Choose category: ");
Console.WriteLine("1 - Computers");
Console.WriteLine("2 - Movies");
Console.WriteLine("3 - History");
int choose = int.Parse(Console.ReadLine());
Category c;
switch (choose)
{
    case 1:
    c = Category.computer;
    break;
    case 2:
    c = Category.movie;
    break;
    case 3:
    c = Category.history;
    break;
    default:
    c = 0;
    break;
}
Console.Clear();

Console.WriteLine($"You choosed: {c.ToString()}");

IJsonToModel mdl = new JsonToModel();
Questions q = mdl.GetQuestions(c, Difficulty.easy, 2);


List<string> answers = new();
Dictionary<string, List<string>> ans = new();
Dictionary<string, string> rightAnswer = new();
int count = 1;
foreach (var item in q.Results)
{

    rightAnswer.Add(item.Question, item.CorrectAnswer);
    answers.Add(item.CorrectAnswer);
    foreach (var wa in item.IncorrectAnswers)
    {
        answers.Add(wa);
    }
    ans.Add(item.Question, new List<string>(answers));
    answers.RemoveRange(0, answers.Count);
    count++;

}

var rnd = new Random();
var userInput = "0";
int questionNumber = 0;
var answerCheck = 0;
List<int> answerQuestions = new();
foreach (var lst in ans)
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine(lst.Key);
    var randomized = lst.Value.OrderBy(item => rnd.Next()).ToList();
    Console.WriteLine("Choose your answer");
    foreach (var b in randomized)
    {
        questionNumber += 1;
        Console.WriteLine($"{questionNumber}. {b}");
    }
    questionNumber = 0;
    userInput = Console.ReadLine();
    Console.WriteLine("Your answer: " + randomized[int.Parse(userInput) - 1]);

    if (randomized[int.Parse(userInput) - 1] == rightAnswer.Values.ElementAt(answerCheck))
    {
        Console.WriteLine("Yes, correct");
        answerQuestions.Add(1);
    }
    else
    {
        Console.WriteLine("No wrong!");
        answerQuestions.Add(0);
    }

    Console.Clear();
    answerCheck++;
    Console.WriteLine($"You choosed: {c.ToString()}");
    Console.WriteLine("----------------------------------------");
}



Console.Clear();
Console.WriteLine("---------------Right Answers--------------");
int checkAnswerdQuetsion = 0;
int right = 0;

foreach (var item in rightAnswer)
{


    if (answerQuestions[checkAnswerdQuetsion] == 1)
    {
        right++;
        
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("---------------------------------------------");

        Console.WriteLine($"Question: {item.Key}");
        Console.WriteLine($"Correct answer: {item.Value}");
        Console.WriteLine("---------------------------------------------");
    }
    else if (answerQuestions[checkAnswerdQuetsion] == 0)
    {
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine($"Question: {item.Key}");
        Console.WriteLine($"Correct answer: {item.Value}");
        Console.WriteLine("---------------------------------------------");
    }
    checkAnswerdQuetsion++;
    Console.ResetColor();

}



Console.WriteLine($"Summary: {right}/{answerQuestions.Count()}");











