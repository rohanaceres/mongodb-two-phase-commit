using MongoDbGenericRepository;
using MongoDbTwoPhaseCommitExample.Core.Repositories;

namespace MongoDbTwoPhaseCommitExample.Repository
{
    // TODO: Doc.
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Database abstraction responsible for calling MongoDB functions.
        /// </summary>
        private readonly IBaseMongoRepository _mongoRepository = new MongoRepository(
            "mongodb://localhost:27017",
            "TwoPhaseCommitExample");

        private readonly IUserRepository _userRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly ITransferRepository _transferRepository;

        public IUserRepository UserRepository => _userRepository;
        public IAccountRepository AccountRepository => _accountRepository;
        public ITransferRepository TransferRepository => _transferRepository;

        public UnitOfWork()
        {
            this._userRepository = new UserRepository(_mongoRepository);
            this._accountRepository = new AccountRepository(_mongoRepository);
            this._transferRepository = new TransferRepository(_mongoRepository);
        }

        public void BeginTransaction()
        {

        }

        public void Commit()
        {

        }

        public void Rollback()
        {

        }
    }
}
