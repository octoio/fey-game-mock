using System;

namespace Octoio.Fey.Data.Dto
{
    public abstract partial class Drop
    {
        public abstract T Accept<T>(IDropVisitor<T> visitor);
    }

    public partial class GoldDrop : Drop
    {
        public override T Accept<T>(IDropVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class EquipmentDrop : Drop
    {
        public override T Accept<T>(IDropVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class WeaponDrop : Drop
    {
        public override T Accept<T>(IDropVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class SkillDrop : Drop
    {
        public override T Accept<T>(IDropVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

}
