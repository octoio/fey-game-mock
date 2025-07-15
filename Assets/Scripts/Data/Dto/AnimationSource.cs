using System;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public abstract partial class AnimationSource
    {
        public bool RequiresSheathWeapon { get; private set; }
        public float OriginalDuration { get; private set; }
        public bool Looping { get; private set; }
        public Type.Animation Type { get; private set; }
    }
}
