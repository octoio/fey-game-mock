using System;
using Octoio.Fey.Data.Interface;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class DropTableEntityDefinition : EntityDefinition, IEntityDefinition<DropTable>
    {
        public DropTable Entity { get; private set; }
    }
}
