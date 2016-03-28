using Education.Data.Abstracts;
using Education.Data.Concreat;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Data.Helpers
{
    public static class Helper
    {

        public static Question CreateQuestion(BsonDocument data)
        {
            var q = new ChoiceQuestion();
                       

            q.id = data.GetValue("_id").AsObjectId.ToString();

            q.Question = data.GetValue("Question").AsString;

            var d = data.GetValue("Choices") as BsonArray;
            foreach (var item in d)
            {
                q.Choices.Add(item.AsString);
            }


            q.Answer = data.GetValue("Answer").AsString;

            BsonValue bValue;
            if (data.TryGetValue("Difficulty", out bValue))
            {
                q.Difficulty = (Difficulty)Enum.Parse(typeof(Difficulty), bValue.AsString);
            }

            return q;

        }

    }
}
