using System;
using Octoio.Fey.Data.Type;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public class RequirementEvaluation
    {
        public RequirementOperator Operator { get; private set; }
        public Requirement[] Requirements { get; private set; }
    }
}
