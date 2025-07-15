using System;

namespace Octoio.Fey.Data.Dto
{
    public interface IRequirementVisitor<TResult>
    {
        TResult Visit(Dto.CharacterRequirement characterRequirement);
        TResult Visit(Dto.WeaponCategoryRequirement weaponCategoryRequirement);
    }
}
