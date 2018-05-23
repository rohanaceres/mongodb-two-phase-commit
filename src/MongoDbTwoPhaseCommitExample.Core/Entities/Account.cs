using MongoDbGenericRepository.Models;
using System;

namespace MongoDbTwoPhaseCommitExample.Core.Entities
{
    // TODO: Doc.
    public class Account : Document
    {
        public Guid UserId { get; set; }
        public int Funds { get; set; }
    }
}
