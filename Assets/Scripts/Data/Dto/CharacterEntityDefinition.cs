using System;
using Octoio.Fey.Data.Interface;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class CharacterEntityDefinition : EntityDefinition, IEntityDefinition<Character>
    {
        public Character Entity { get; private set; }
    }
}
