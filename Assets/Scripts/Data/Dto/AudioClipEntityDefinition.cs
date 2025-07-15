using System;
using Octoio.Fey.Data.Interface;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class AudioClipEntityDefinition : EntityDefinition, IEntityDefinition<AudioClip>
    {
        public AudioClip Entity { get; private set; }
    }
}
