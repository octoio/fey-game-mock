using System;
using Octoio.Fey.Data.Type;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public abstract partial class SkillEffectTargetMechanic
    {
        public SkillEffectTargetMechanicType Type { get; private set; }
    }
}
