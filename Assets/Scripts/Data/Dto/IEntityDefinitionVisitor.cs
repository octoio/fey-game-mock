using System;

namespace Octoio.Fey.Data.Dto
{
    public interface IEntityDefinitionVisitor<TResult>
    {
        TResult Visit(Dto.WeaponEntityDefinition weaponEntityDefinition);
        TResult Visit(Dto.SkillEntityDefinition skillEntityDefinition);
        TResult Visit(Dto.EquipmentEntityDefinition equipmentEntityDefinition);
        TResult Visit(Dto.StatusEntityDefinition statusEntityDefinition);
        TResult Visit(Dto.ModelEntityDefinition modelEntityDefinition);
        TResult Visit(Dto.ImageEntityDefinition imageEntityDefinition);
        TResult Visit(Dto.CursorEntityDefinition cursorEntityDefinition);
        TResult Visit(Dto.StatEntityDefinition statEntityDefinition);
        TResult Visit(Dto.QualityEntityDefinition qualityEntityDefinition);
        TResult Visit(Dto.AudioClipEntityDefinition audioClipEntityDefinition);
        TResult Visit(Dto.SoundEntityDefinition soundEntityDefinition);
        TResult Visit(Dto.SoundBankEntityDefinition soundBankEntityDefinition);
        TResult Visit(Dto.DropTableEntityDefinition dropTableEntityDefinition);
        TResult Visit(Dto.CharacterEntityDefinition characterEntityDefinition);
        TResult Visit(Dto.AnimationSourceEntityDefinition animationSourceEntityDefinition);
        TResult Visit(Dto.AnimationEntityDefinition animationEntityDefinition);
    }
}
