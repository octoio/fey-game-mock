using System;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public class FloatRange
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
    }
}
