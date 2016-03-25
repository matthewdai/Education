using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Data
{
    public class Shared
    {

        public static readonly Shared GetSharedSingleton = new Shared();

        public IMongoClient _client;
        public IMongoDatabase _database;

        private Shared()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("Education");
        }
    }
}
