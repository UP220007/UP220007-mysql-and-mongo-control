using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace API.Repository
{
    public class MongoDBRepository
    {
        public MongoClient client;
        public IMongoDatabase dB;

        public MongoDBRepository()
        {
            client = new MongoClient("mongodb://127.0.0.1:27017");
            dB = client.GetDatabase("FondoHistorico");
        }
    }
}