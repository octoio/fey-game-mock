using System;

namespace Octoio.Fey.Data.Dto
{
    public interface IDropVisitor<TResult>
    {
        TResult Visit(Dto.GoldDrop goldDrop);
        TResult Visit(Dto.EquipmentDrop equipmentDrop);
        TResult Visit(Dto.WeaponDrop weaponDrop);
        TResult Visit(Dto.SkillDrop skillDrop);
    }
}
