using System;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public abstract partial class EntityDefinition
    {
        public string Owner { get; private set; }
        public Type.Entity Type { get; private set; }
        public string Key { get; private set; }
        public uint Version { get; private set; }
        public string Id { get; private set; }
    }
}
