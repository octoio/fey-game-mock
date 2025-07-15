using System;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public class StatAffix
    {
        public Type.Stat Stat { get; private set; }
        public FloatRange Value { get; private set; }
    }
}
