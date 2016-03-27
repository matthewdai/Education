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
                       

            q.id = data.GetValue("_id").ToString();

            q.Question = data.GetValue("Question").ToString();

            return q;

        }

    }
}
