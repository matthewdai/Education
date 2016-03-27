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

            Assert.AreEqual(ss.Count(), 1);

        }


        [TestMethod]
        public void Test_AddQuestion()
        {
            var q = new ChoiceQuestion();
            q.Question = "Where were you born?";

            q.Choices = new List<string>() { "ChangSha", "Shaoyang", "Beijing", "Shanghai" };

            q.Answer = "Shaoyang";

            var repo = new QuestionsRepository();

            repo.AddQuestion(q);

        }

    }
}
