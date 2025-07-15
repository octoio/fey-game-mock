
namespace Octoio.Fey.Data.Dto
{
    public class Sound
    {
        public EntityReference[] AudioReferences { get; private set; }
        public float SpatialBlend { get; private set; }
        public float Volume { get; private set; }
    }
}
