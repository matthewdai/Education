using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Education.Data.Concreat;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;
using Education.Data;
using Education.Data.Abstracts;

namespace Education.Test
{
    [TestClass]
    public class UnitTest1
    {
        private IQuestionsRepository _Reporitory = Factory.GetReporitory();


        [TestMethod]
        public void Test_QueryQuestions()
        {
            var filter = Builders<BsonDocument>.Filter.Empty;

            var ss = _Reporitory.GetQuestions(filter);

            var count = ss.Count();

            Assert.AreEqual(count > 0, true);

        }


        [TestMethod]
        public void Test_AddQuestion()
        {
            var q = new ChoiceQuestion();
            q.Question = "Where were you born?";

            q.Choices.Add("ChangSha");
            q.Choices.Add("Shaoyang");
            q.Choices.Add("Beijing");
            q.Choices.Add("Shanghai");

            q.Answer = "Shaoyang";

            _Reporitory.AddQuestion(q);

        }

    }
}
