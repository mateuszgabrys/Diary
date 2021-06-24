using Diary.API.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diary.API.Data
{
    public class EntryContext
    {
        public IMongoCollection<Entry> Entries { get; }
        public EntryContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));
            Entries = database.GetCollection<Entry>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));
            SeedData(Entries);
        }

        private static void SeedData(IMongoCollection<Entry> entryCollection)
        {
            bool existProduct = entryCollection.Find(p => true).Any();
            if (!existProduct)
            {
                entryCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Entry> GetPreconfiguredProducts()
        {
            return new List<Entry>()
            {
                new Entry()
                {
                    DateOfCreation = DateTime.Now,
                    Description = "Description1",
                    Id = "60be8ac8bf3fb55f30249a71",
                    Title = "Title1",
                    Tags = new List<string>() {"Tag1", "Tag2"}
                },
                new Entry()
                {
                    DateOfCreation = DateTime.Now,
                    Description = "Description2",
                    Id = "60be8ad96844117b8ab8e49a",
                    Title = "Title2",
                    Tags = new List<string>() {"Tag3", "Tag4"}
                }

            };
        }
    }
}
