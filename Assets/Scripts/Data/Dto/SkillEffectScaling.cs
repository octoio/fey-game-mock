using System;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public class SkillEffectScaling
    {
        public float Base { get; private set; }
        public FloatRange Scaling { get; private set; }
        public Type.Stat Stat { get; private set; }
    }
}
