using System;
using Octoio.Fey.Data.Interface;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class WeaponEntityDefinition : EntityDefinition, IEntityDefinition<Weapon>
    {
        public Weapon Entity { get; private set; }
    }
}
