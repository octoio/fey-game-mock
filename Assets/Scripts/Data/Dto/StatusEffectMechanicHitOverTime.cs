
namespace Octoio.Fey.Data.Dto
{
    public partial class StatusEffectMechanicHitOverTime : StatusEffectMechanic
    {
        public Type.Hit Hit { get; private set; }
        public float TickRate { get; private set; }
    }
}
