using System;
using Octoio.Fey.Data.Type;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class SkillActionParallelNode : SkillActionNode
    {
        public SkillActionNode[] Children { get; private set; }
        public int Loop { get; private set; }
    }
}
