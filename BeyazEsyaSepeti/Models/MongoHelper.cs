using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace BeyazEsyaSepeti.Models
{
    public class MongoHelper
    {
        private IMongoClient client;
        private IMongoDatabase database;
        public MongoHelper()
        {
            var connectionString = "mongodb+srv://sabri:sabri@cluster0.jxjrm.mongodb.net/myFirstDatabase?retryWrites=true&w=majority";
            client = new MongoClient(connectionString);
            database = client.GetDatabase("beyazesya");
        }
        

        public IMongoCollection<User> Users
        {
            get { return database.GetCollection<User>("users"); }
        }

        public IMongoCollection<Product> Products
        {
            get { return database.GetCollection<Product>("products"); }
        }
    }
}
