using MongoDbGenericRepository;

namespace MongoDbTwoPhaseCommitExample.Repository
{
    /// <summary>
    /// Base class for every repository. Contains the logic to access the MongoDB functions.
    /// </summary>
    abstract public class BaseRepository
    {
        /// <summary>
        /// Responsible for making changes in the MongoDB database.
        /// </summary>
        public IBaseMongoRepository MongoRepository { get; private set; }

        public BaseRepository(IBaseMongoRepository mongoRepository) 
        {
            this.MongoRepository = mongoRepository;
        }
    }
}
