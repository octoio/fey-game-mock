using System;
using UnityEngine;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class WeaponDrop : Drop
    {
        public EntityReference Weapon { get; private set; }
    }
}
