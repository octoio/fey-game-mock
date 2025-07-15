using System;
using Octoio.Fey.Data.Interface;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class AnimationSourceEntityDefinition : EntityDefinition, IEntityDefinition<AnimationSource>
    {
        public AnimationSource Entity { get; private set; }
    }
}
