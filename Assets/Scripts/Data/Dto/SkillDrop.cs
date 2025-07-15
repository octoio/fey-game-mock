using System;
using UnityEngine;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class SkillDrop : Drop
    {
        public EntityReference Skill { get; private set; }
    }
}
