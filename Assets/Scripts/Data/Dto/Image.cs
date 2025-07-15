using System;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public class Image
    {
        public Type.Image Type { get; private set; }
        public string Path { get; private set; }
        public Size Size { get; private set; }
    }
}
