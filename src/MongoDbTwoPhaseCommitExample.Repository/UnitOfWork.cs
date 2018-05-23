using MongoDbTwoPhaseCommitExample.Core.Repositories;

namespace MongoDbTwoPhaseCommitExample.Repository
{
    // TODO: Doc.
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IUserRepository _userRepository = new UserRepository();
        private readonly IAccountRepository _accountRepository = new AccountRepository();
        private readonly ITransferRepository _transferRepository = new TransferRepository();

        public IUserRepository UserRepository => _userRepository;
        public IAccountRepository AccountRepository => _accountRepository;
        public ITransferRepository TransferRepository => _transferRepository;
    }
}
