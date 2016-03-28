using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Education.Data.Concreat;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;

namespace Education.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_QueryQuestions()
        {
            var repo = new QuestionsRepository();

            var filter = Builders<BsonDocument>.Filter.Empty;

            var ss = repo.GetQuestions(filter);

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

            var repo = new QuestionsRepository();

            repo.AddQuestion(q);

        }

    }
}
