using System;

namespace Octoio.Fey.Data.Dto
{
    public abstract partial class AnimationSource
    {
        public abstract T Accept<T>(IAnimationSourceVisitor<T> visitor);
    }

    public partial class GenericAnimationSource : AnimationSource
    {
        public override T Accept<T>(IAnimationSourceVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class HumanoidDaggerAttackAnimationSource : AnimationSource
    {
        public override T Accept<T>(IAnimationSourceVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class HumanoidSwordAttackAnimationSource : AnimationSource
    {
        public override T Accept<T>(IAnimationSourceVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class HumanoidSpearAttackAnimationSource : AnimationSource
    {
        public override T Accept<T>(IAnimationSourceVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class HumanoidMaceAttackAnimationSource : AnimationSource
    {
        public override T Accept<T>(IAnimationSourceVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class HumanoidTwoHandedStaffAttackAnimationSource : AnimationSource
    {
        public override T Accept<T>(IAnimationSourceVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class HumanoidTwoHandedAxeAttackAnimationSource : AnimationSource
    {
        public override T Accept<T>(IAnimationSourceVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class HumanoidItemAttackAnimationSource : AnimationSource
    {
        public override T Accept<T>(IAnimationSourceVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class HumanoidShieldAttackAnimationSource : AnimationSource
    {
        public override T Accept<T>(IAnimationSourceVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class HumanoidTwoHandedSpearAttackAnimationSource : AnimationSource
    {
        public override T Accept<T>(IAnimationSourceVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class HumanoidTwoHandedSwordAttackAnimationSource : AnimationSource
    {
        public override T Accept<T>(IAnimationSourceVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class HumanoidUnarmedAttackAnimationSource : AnimationSource
    {
        public override T Accept<T>(IAnimationSourceVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class HumanoidCastAnimationSource : AnimationSource
    {
        public override T Accept<T>(IAnimationSourceVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class HumanoidAttackCastAnimationSource : AnimationSource
    {
        public override T Accept<T>(IAnimationSourceVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class HumanoidDualAttackAnimationSource : AnimationSource
    {
        public override T Accept<T>(IAnimationSourceVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class HumanoidBlockedHitAnimationSource : AnimationSource
    {
        public override T Accept<T>(IAnimationSourceVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

}
