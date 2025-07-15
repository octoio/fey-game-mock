
namespace Octoio.Fey.Data.Dto
{
    public class Animation
    {
        public Metadata Metadata { get; private set; }
        public float Duration { get; private set; }
        public EntityReference[] Sources { get; private set; }
    }
}
