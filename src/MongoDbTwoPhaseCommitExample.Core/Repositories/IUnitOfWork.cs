namespace MongoDbTwoPhaseCommitExample.Core.Repositories
{
    // TODO: Doc
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IAccountRepository AccountRepository { get; }
        ITransferRepository TransferRepository { get; }
    }
}
