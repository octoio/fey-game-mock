using System;
using Octoio.Fey.Data.Type;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class CharacterRequirement : Requirement
    {
        public Type.Character Character { get; private set; }
    }
}
