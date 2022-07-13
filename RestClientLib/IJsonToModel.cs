using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestClientLib
{
    public interface IJsonToModel
    {
        Questions GetQuestions(Category category, Difficulty difficulty, int amount);
    }
}