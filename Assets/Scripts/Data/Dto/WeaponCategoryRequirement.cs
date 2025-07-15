using System;
using Octoio.Fey.Data.Type;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class WeaponCategoryRequirement : Requirement
    {
        public WeaponCategory WeaponCategory { get; private set; }
    }
}
