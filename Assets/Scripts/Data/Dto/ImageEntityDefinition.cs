using System;
using Octoio.Fey.Data.Interface;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class ImageEntityDefinition : EntityDefinition, IEntityDefinition<Image>
    {
        public Image Entity { get; private set; }
    }
}
