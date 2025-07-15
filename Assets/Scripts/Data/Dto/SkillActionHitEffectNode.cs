using System;
using Octoio.Fey.Data.Type;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class SkillActionHitEffectNode : SkillActionNode
    {
        public HitEffect HitEffect { get; private set; }
    }
}
