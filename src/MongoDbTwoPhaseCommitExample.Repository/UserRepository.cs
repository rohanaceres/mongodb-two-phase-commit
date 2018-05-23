using MongoDbGenericRepository;
using MongoDbTwoPhaseCommitExample.Core.Repositories;

namespace MongoDbTwoPhaseCommitExample.Repository
{
    // TODO: Doc
    internal class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(IBaseMongoRepository mongoRepository) 
            : base(mongoRepository) { }
    }
}