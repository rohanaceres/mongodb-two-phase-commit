using MongoDbGenericRepository;
using MongoDbTwoPhaseCommitExample.Core.Repositories;

namespace MongoDbTwoPhaseCommitExample.Repository
{
    // TODO: Doc
    internal class AccountRepository : BaseRepository, IAccountRepository
    {
        public AccountRepository(IBaseMongoRepository mongoRepository) 
            : base(mongoRepository) { }
    }
}