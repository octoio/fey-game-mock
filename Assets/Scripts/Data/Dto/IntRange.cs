using System;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public class IntRange
    {
        public int Min { get; private set; }
        public int Max { get; private set; }
    }
}
