using System;
using Octoio.Fey.Data.Interface;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class StatEntityDefinition : EntityDefinition, IEntityDefinition<Stat>
    {
        public Stat Entity { get; private set; }
    }
}
