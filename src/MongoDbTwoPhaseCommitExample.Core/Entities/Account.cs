using System;

namespace MongoDbTwoPhaseCommitExample.Core.Entities
{
    // TODO: Doc.
    public class Account
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int Funds { get; set; }
    }
}
