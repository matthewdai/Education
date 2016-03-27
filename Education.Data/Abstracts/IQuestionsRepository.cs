using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Data.Abstracts
{
    interface IQuestionsRepository
    {

        void UpdateQuestion(Question question);


        void AddQuestion(Question question);


        IEnumerable<Question> GetQuestions(FilterDefinition<BsonDocument> filter);


    }
}
