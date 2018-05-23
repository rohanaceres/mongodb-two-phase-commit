using System;

namespace MongoDbTwoPhaseCommitExample.Core.Entities
{
    // TODO: Doc.
    public class Transfer
    {
        public Guid Id { get; set; }
        public Guid OriginatorUserId { get; set; }
        public Guid DestinationUserId { get; set; }
        public int AmountInCents { get; set; }
        public DateTime DateTime { get; set; }
    }
}
