using System;
using Octoio.Fey.Data.Type;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class SkillEffectTargetMechanicTeam : SkillEffectTargetMechanic
    {
        public CharacterTeam Team { get; private set; }
    }
}
