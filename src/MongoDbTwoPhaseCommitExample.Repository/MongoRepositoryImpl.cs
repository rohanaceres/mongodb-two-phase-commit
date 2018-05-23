using MongoDbGenericRepository;

namespace MongoDbTwoPhaseCommitExample.Repository
{
    /// <summary>
    /// MongoDB abstraction implementation.
    /// </summary>
    public class MongoRepository : BaseMongoRepository
    {
        public MongoRepository(string connectionString, string databaseName)
            : base(connectionString, databaseName) { }
    }
}
