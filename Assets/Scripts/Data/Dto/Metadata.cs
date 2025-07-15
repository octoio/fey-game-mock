using System;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public class Metadata
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
    }
}
