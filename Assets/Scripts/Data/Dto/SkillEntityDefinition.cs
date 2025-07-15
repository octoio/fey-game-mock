using System;
using Octoio.Fey.Data.Interface;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class SkillEntityDefinition : EntityDefinition, IEntityDefinition<Skill>
    {
        public Skill Entity { get; private set; }
    }
}
