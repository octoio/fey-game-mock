using System;

namespace Octoio.Fey.Data.Dto
{
    public abstract partial class EntityDefinition
    {
        public abstract T Accept<T>(IEntityDefinitionVisitor<T> visitor);
    }

    public partial class WeaponEntityDefinition : EntityDefinition
    {
        public override T Accept<T>(IEntityDefinitionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class SkillEntityDefinition : EntityDefinition
    {
        public override T Accept<T>(IEntityDefinitionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class EquipmentEntityDefinition : EntityDefinition
    {
        public override T Accept<T>(IEntityDefinitionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class StatusEntityDefinition : EntityDefinition
    {
        public override T Accept<T>(IEntityDefinitionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class ModelEntityDefinition : EntityDefinition
    {
        public override T Accept<T>(IEntityDefinitionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class ImageEntityDefinition : EntityDefinition
    {
        public override T Accept<T>(IEntityDefinitionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class CursorEntityDefinition : EntityDefinition
    {
        public override T Accept<T>(IEntityDefinitionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class StatEntityDefinition : EntityDefinition
    {
        public override T Accept<T>(IEntityDefinitionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class QualityEntityDefinition : EntityDefinition
    {
        public override T Accept<T>(IEntityDefinitionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class AudioClipEntityDefinition : EntityDefinition
    {
        public override T Accept<T>(IEntityDefinitionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class SoundEntityDefinition : EntityDefinition
    {
        public override T Accept<T>(IEntityDefinitionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class SoundBankEntityDefinition : EntityDefinition
    {
        public override T Accept<T>(IEntityDefinitionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class DropTableEntityDefinition : EntityDefinition
    {
        public override T Accept<T>(IEntityDefinitionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class CharacterEntityDefinition : EntityDefinition
    {
        public override T Accept<T>(IEntityDefinitionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class AnimationSourceEntityDefinition : EntityDefinition
    {
        public override T Accept<T>(IEntityDefinitionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

    public partial class AnimationEntityDefinition : EntityDefinition
    {
        public override T Accept<T>(IEntityDefinitionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }

}
