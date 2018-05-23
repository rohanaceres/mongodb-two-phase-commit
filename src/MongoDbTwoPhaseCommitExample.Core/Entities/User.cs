using MongoDbGenericRepository.Models;
using System;

namespace MongoDbTwoPhaseCommitExample.Core.Entities
{
    // TODO: Doc.
    public class User : Document
    {
        public string Name { get; set; }
    }
}
