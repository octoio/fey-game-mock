using System;
using UnityEngine;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public class DropEvaluation
    {
        public RequirementEvaluation Operator { get; private set; }
        public Drop[] Drops { get; private set; }
    }
}
