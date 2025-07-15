using System;
using Octoio.Fey.Data.Type;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public class Weapon
    {
        public Metadata Metadata { get; private set; }
        public WeaponCategory Category { get; private set; }
        public Data.Type.Quality Quality { get; private set; }
        public WeaponSheatheLocation SheatheLocation { get; private set; }
        public EntityReference IconReference { get; private set; }
        public StatAffix[] BaseStatAffixes { get; private set; }
        public IntRange RandomStatAffixCount { get; private set; }
        public StatAffix[] RandomStatAffixes { get; private set; }
        public Optional<EntityReference> BasicAttack { get; private set; }
        public ModelAnchorSet ModelAnchorSet { get; private set; }
    }
}
