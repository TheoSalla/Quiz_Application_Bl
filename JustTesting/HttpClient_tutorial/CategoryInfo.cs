using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HttpClient_tutorial
{
    public class CategoryInfo
    {
        // [JsonPropertyName("category_id")]
        public int CategoryId { get; set; }
        // [JsonPropertyName("category_question_count")]
        public QuestionCount CategoryQuestionCount { get; set; }

    }

    public class QuestionCount
    {
        // [JsonPropertyName("total_question_count")]
        public int TotalQuestionCount { get; set; }
        // [JsonPropertyName("total_easy_question_count")]
        public int TotalEasyQuestionCount { get; set; }
        // [JsonPropertyName("total_medium_question_count")]
        public int TotalMediumQuestionCount { get; set; }
        // [JsonPropertyName("total_hard_question_count")]
        public int TotalHardQuestionCount { get; set; }

    }
}