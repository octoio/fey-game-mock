using System;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public class ModelAnchorSet
    {
        public EntityReference ModelReference { get; private set; }
        public ModelAnchor[] Anchors { get; private set; }
    }
}
