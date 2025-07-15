using System;
using Octoio.Fey.Data.Type;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class SkillActionDelayNode : SkillActionNode
    {
        public float Delay { get; private set; }
    }
}
