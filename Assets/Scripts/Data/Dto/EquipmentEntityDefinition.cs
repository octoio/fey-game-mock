using System;
using Octoio.Fey.Data.Interface;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class EquipmentEntityDefinition : EntityDefinition, IEntityDefinition<Equipment>
    {
        public Equipment Entity { get; private set; }
    }
}
