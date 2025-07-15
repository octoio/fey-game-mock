using System;
using Octoio.Fey.Data.Interface;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class SoundEntityDefinition : EntityDefinition, IEntityDefinition<Sound>
    {
        public Sound Entity { get; private set; }
    }
}
