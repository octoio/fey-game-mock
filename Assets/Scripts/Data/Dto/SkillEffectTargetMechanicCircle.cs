using System;
using Octoio.Fey.Data.Type;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class SkillEffectTargetMechanicCircle : SkillEffectTargetMechanic
    {
        public int HitCount { get; private set; }
        public float Radius { get; private set; }
    }
}
