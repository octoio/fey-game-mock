using System;
using Octoio.Fey.Data.Type;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class SkillActionAnimationNode : SkillActionNode
    {
        public bool ShowProgress { get; private set; }
        public float Duration { get; private set; }
        public EntityReference[] Animations { get; private set; }
    }
}
