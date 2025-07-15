using System;
using Octoio.Fey.Data.Interface;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class StatusEntityDefinition : EntityDefinition, IEntityDefinition<Status>
    {
        public Status Entity { get; private set; }
    }
}
