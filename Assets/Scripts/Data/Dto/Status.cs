
namespace Octoio.Fey.Data.Dto
{
    public class Status
    {
        public Metadata Metadata { get; private set; }
        public StatusEffectMechanic Mechanic { get; private set; }
        public StatusStack Stack { get; private set; }
    }
}
