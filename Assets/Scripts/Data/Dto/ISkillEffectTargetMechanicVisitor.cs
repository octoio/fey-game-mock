using System;

namespace Octoio.Fey.Data.Dto
{
    public interface ISkillEffectTargetMechanicVisitor<TResult>
    {
        TResult Visit(Dto.SkillEffectTargetMechanicSelf skillEffectTargetMechanicSelf);
        TResult Visit(Dto.SkillEffectTargetMechanicTeam skillEffectTargetMechanicTeam);
        TResult Visit(Dto.SkillEffectTargetMechanicSelected skillEffectTargetMechanicSelected);
        TResult Visit(Dto.SkillEffectTargetMechanicCircle skillEffectTargetMechanicCircle);
        TResult Visit(Dto.SkillEffectTargetMechanicRectangle skillEffectTargetMechanicRectangle);
    }
}
