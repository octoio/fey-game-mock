using System;
using Octoio.Fey.Data.Interface;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class CursorEntityDefinition : EntityDefinition, IEntityDefinition<Cursor>
    {
        public Cursor Entity { get; private set; }
    }
}
