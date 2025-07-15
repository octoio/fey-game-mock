using System;
using Octoio.Fey.Data.Type;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public class ModelAnchor
    {
        public ModelAnchorPosition Position { get; private set; }
        public Transform LocalTransform { get; private set; }
        public ModelVariant Variant { get; private set; }
    }
}
