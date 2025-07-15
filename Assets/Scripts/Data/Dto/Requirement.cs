using System;
using Octoio.Fey.Data.Type;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public abstract partial class Requirement
    {
        public Type.Requirement Type { get; private set; }
    }
}
