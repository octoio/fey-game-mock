using System;
using Octoio.Fey.Data.Interface;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class QualityEntityDefinition : EntityDefinition, IEntityDefinition<Quality>
    {
        public Quality Entity { get; private set; }
    }
}
