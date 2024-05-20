using MongoDB.Driver;
using abra_be.Models;

namespace abra_be.Services
{
    public class MongoDBService
    {
        private readonly IMongoCollection<Pet> _petsCollection;

        public MongoDBService(IMongoClient client, IConfiguration configuration)
        {
            var databaseName = configuration.GetValue<string>("MongoDBSettings:DatabaseName");
            var database = client.GetDatabase(databaseName);
            _petsCollection = database.GetCollection<Pet>("Pets");
        }

        public async Task<List<Pet>> GetAsync()
        {
            return await _petsCollection.Find(_ => true).ToListAsync();
        }

        public async Task CreateAsync(Pet pet)
        {
            pet.CreatedAt = DateTime.Now;
            pet.Id = null;
            // Im not sure if that how its implemented
            await _petsCollection.InsertOneAsync(pet);
        }


    }
}
