using System;

namespace Octoio.Fey.Data.Dto
{
    public abstract partial class StatusEffectMechanic
    {
        public abstract T Accept<T>(IStatusEffectMechanicVisitor<T> visitor);
    }

    public partial class StatusEffectMechanicStatChange : StatusEffectMechanic
    {
        public override T Accept<T>(IStatusEffectMechanicVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class StatusEffectMechanicHitOverTime : StatusEffectMechanic
    {
        public override T Accept<T>(IStatusEffectMechanicVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

}
