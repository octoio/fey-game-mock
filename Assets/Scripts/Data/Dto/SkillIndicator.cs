using UnityEngine;
using Octoio.Fey.Data.Type;

namespace Octoio.Fey.Data.Dto
{
    public class SkillIndicator
    {
        public EntityReference ModelReference { get; private set; }
        public SkillIndicatorPosition Position { get; private set; }
        public Vector3 Scale { get; private set; }
    }
}
