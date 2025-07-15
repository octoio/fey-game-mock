using System;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public class EntityIndexContainer
    {
        public EntityIndex[] Indices { get; private set; }
    }
}
