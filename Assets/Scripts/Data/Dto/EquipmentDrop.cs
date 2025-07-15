using System;
using UnityEngine;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class EquipmentDrop : Drop
    {
        public EntityReference Equipment { get; private set; }
    }
}
