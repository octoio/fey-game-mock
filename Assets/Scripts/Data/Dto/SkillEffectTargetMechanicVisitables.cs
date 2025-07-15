using System;

namespace Octoio.Fey.Data.Dto
{
    public abstract partial class SkillEffectTargetMechanic
    {
        public abstract T Accept<T>(ISkillEffectTargetMechanicVisitor<T> visitor);
    }

    public partial class SkillEffectTargetMechanicSelf : SkillEffectTargetMechanic
    {
        public override T Accept<T>(ISkillEffectTargetMechanicVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class SkillEffectTargetMechanicTeam : SkillEffectTargetMechanic
    {
        public override T Accept<T>(ISkillEffectTargetMechanicVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class SkillEffectTargetMechanicSelected : SkillEffectTargetMechanic
    {
        public override T Accept<T>(ISkillEffectTargetMechanicVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class SkillEffectTargetMechanicCircle : SkillEffectTargetMechanic
    {
        public override T Accept<T>(ISkillEffectTargetMechanicVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class SkillEffectTargetMechanicRectangle : SkillEffectTargetMechanic
    {
        public override T Accept<T>(ISkillEffectTargetMechanicVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

}
