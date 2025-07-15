using System;
using Octoio.Fey.Data.Interface;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class ModelEntityDefinition : EntityDefinition, IEntityDefinition<Model>
    {
        public Model Entity { get; private set; }
    }
}
