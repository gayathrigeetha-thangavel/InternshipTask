using backend.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace backend.Services;

public class UserService{
    private readonly IMongoCollection<User> _userCollection;

    public UserService(IOptions<UserSettings> userSettings)
    {
        var mongoClient = new MongoClient(
            userSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            userSettings.Value.DatabaseName);

        _userCollection = mongoDatabase.GetCollection<User>(
            userSettings.Value.UserCollectionName);
    }


     public async Task CreateAsync(User newUser) =>
        await _userCollection.InsertOneAsync(newUser);

    public async Task<User?> GetAsync(string id) =>
        await _userCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task UpdateAsync(string id, User updatedUser) =>
        await _userCollection.ReplaceOneAsync(x => x.Id == id, updatedUser);

    public async Task RemoveAsync(string id) =>
        await _userCollection.DeleteOneAsync(x => x.Id == id);

    public async Task<List<User>> GetAsync() =>
        await _userCollection.Find(_ => true).ToListAsync();
}