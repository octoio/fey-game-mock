using System;
using Octoio.Fey.Data.Interface;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class SoundBankEntityDefinition : EntityDefinition, IEntityDefinition<SoundBank>
    {
        public SoundBank Entity { get; private set; }
    }
}
