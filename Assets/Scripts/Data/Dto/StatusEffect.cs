using System;
using Octoio.Fey.Data.Type;

namespace Octoio.Fey.Data.Dto
{
    public class StatusEffect
    {
        public SkillEffectTargetMechanic TargetMechanic { get; private set; }
        public SkillEffectTarget Target { get; private set; }
        public StatusDuration[] Durations { get; private set; }
        public SkillEffectScaling[] Scalers { get; private set; }
        public EntityReference Status { get; private set; }
    }
}
