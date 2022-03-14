using BeyazEsyaSepeti.Models;
using BeyazEsyaSepeti.Service.Interface;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeyazEsyaSepeti.Service
{
    public class ProductService : IProductService
    {
        public List<Product> GetAllProducts()
        {
            MongoHelper context = new MongoHelper();
            var products = context.Products.Find(new BsonDocument()).ToList();
            return products;
        }

        public Product GetProductById(string Id)
        {
            MongoHelper context = new MongoHelper();
            var product = context.Products.Find(x => x.Id == Id).FirstOrDefault();
            return product;
        }

        public List<Product> GetProductsByCategory(string categoryName)
        {
            MongoHelper context = new MongoHelper();
            var products = context.Products.Find(x => x.Category == categoryName).ToList();
            return products;

        }

        public List<Product> GetProductsById(List<string> selectedIds)
        {
            MongoHelper context = new MongoHelper();
            var builder = Builders<Product>.Filter;
            FilterDefinition<Product> filter;
            filter = builder.Eq("_id", ObjectId.Parse(selectedIds[0]));
            for (int i = 1; i < selectedIds.Count(); i++)
            {
                filter = filter | builder.Eq("_id", ObjectId.Parse(selectedIds[i]));
            }
            var products = context.Products.Find<Product>(filter);
            return products.ToList();
        }

        public void Insert(Product product)
        {
            MongoHelper context = new MongoHelper();
            context.Products.InsertOne(product);
        }
    }
}
