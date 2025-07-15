using System;
using Octoio.Fey.Data.Interface;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class AnimationEntityDefinition : EntityDefinition, IEntityDefinition<Animation>
    {
        public Animation Entity { get; private set; }
    }
}
