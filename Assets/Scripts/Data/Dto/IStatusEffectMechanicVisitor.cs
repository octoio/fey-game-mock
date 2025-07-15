using System;

namespace Octoio.Fey.Data.Dto
{
    public interface IStatusEffectMechanicVisitor<TResult>
    {
        TResult Visit(Dto.StatusEffectMechanicStatChange statusEffectMechanicStatChange);
        TResult Visit(Dto.StatusEffectMechanicHitOverTime statusEffectMechanicHitOverTime);
    }
}
