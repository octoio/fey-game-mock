using System;
using Octoio.Fey.Data.Type;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public abstract partial class SkillActionNode
    {
        public Type.SkillActionNode Type { get; private set; }
        public string Name { get; private set; }
    }
}
