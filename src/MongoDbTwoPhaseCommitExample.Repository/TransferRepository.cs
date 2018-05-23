using MongoDbGenericRepository;
using MongoDbTwoPhaseCommitExample.Core.Repositories;

namespace MongoDbTwoPhaseCommitExample.Repository
{
    // TODO: Doc
    internal class TransferRepository : BaseRepository, ITransferRepository
    {
        public TransferRepository(IBaseMongoRepository mongoRepository) 
            : base(mongoRepository) { }
    }
}