using System;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public class EntityIndex
    {
        public uint Index { get; private set; }
        public string Hash { get; private set; }
        public EntityReference Reference { get; private set; }
        public string FilePath { get; private set; }
    }
}
