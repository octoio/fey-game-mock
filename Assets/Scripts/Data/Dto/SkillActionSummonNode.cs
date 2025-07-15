using System;
using Octoio.Fey.Data.Type;
using UnityEngine;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class SkillActionSummonNode : SkillActionNode
    {
        public EntityReference SummonEntity { get; private set; }
        public Vector3 PositionOffset { get; private set; }
    }
}
