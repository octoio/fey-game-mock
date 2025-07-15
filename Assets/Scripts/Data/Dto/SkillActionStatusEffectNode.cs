using System;
using Octoio.Fey.Data.Type;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class SkillActionStatusEffectNode : SkillActionNode
    {
        public StatusEffect StatusEffect { get; private set; }
    }
}
