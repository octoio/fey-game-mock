using System;

namespace Octoio.Fey.Data.Dto
{
    public abstract partial class Requirement
    {
        public abstract T Accept<T>(IRequirementVisitor<T> visitor);
    }

    public partial class CharacterRequirement : Requirement
    {
        public override T Accept<T>(IRequirementVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class WeaponCategoryRequirement : Requirement
    {
        public override T Accept<T>(IRequirementVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

}
