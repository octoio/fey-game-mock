using System;
using Octoio.Fey.Data.Type;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class SkillEffectTargetMechanicRectangle : SkillEffectTargetMechanic
    {
        public int HitCount { get; private set; }
        public float Width { get; private set; }
        public float Height { get; private set; }
    }
}
