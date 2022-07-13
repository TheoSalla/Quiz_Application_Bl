using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClient_tutorial
{
    public static class Decode
    {
    
         public static Questions DecodeJson(this Questions question)
         {
            for(int i = 0; i < question.Results.Count; i++)
            {
                question.Results[i].Question = System.Web.HttpUtility.HtmlDecode(question.Results[i].Question);
                question.Results[i].CorrectAnswer = System.Web.HttpUtility.HtmlDecode(question.Results[i].CorrectAnswer); 
                for (int j = 0; j < question.Results[i].Incorrect_Answers.Count(); j++)
                {
                    question.Results[i].Incorrect_Answers[j] = System.Web.HttpUtility.HtmlDecode(question.Results[i].Incorrect_Answers[j]); 
                }

            }
            return question;   
         }
    }
}
