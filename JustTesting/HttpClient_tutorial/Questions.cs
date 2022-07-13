using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HttpClient_tutorial
{

    public class Questions
    {

        public int ResponseCode { get; set; }

        public List<Results> Results { get; set; }
    }

    public class Results
    {

        public string Category { get; set; }

        public string Type { get; set; }

        public string Difficulty { get; set; }

        public string Question { get; set; }

        public string CorrectAnswer { get; set; }

        public List<string> Incorrect_Answers { get; set; }
    }
}