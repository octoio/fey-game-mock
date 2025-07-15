using System;
using Octoio.Fey.Data.Type;
using Octoio.Fey.Data.Interface;

namespace Octoio.Fey.Data.Dto
{
    public class EntityReference : IEntityReference
    {
        public string Owner { get; private set; }
        public Entity Type { get; private set; }
        public string Key { get; private set; }
        public uint Version { get; private set; }
        public string Id { get; private set; }
    }
}
