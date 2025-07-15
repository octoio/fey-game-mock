using System;
using UnityEngine;

namespace Octoio.Fey.Data.Dto
{
    public class Character
    {
        public Metadata Metadata { get; private set; }
        public Type.Character Type { get; private set; }
        public Optional<CharacterVariant> Variant { get; private set; }
        public Vector3 PivotOffset { get; private set; }
        public float VisionRange { get; private set; }
        public EntityReference AutoAttack { get; private set; }
        public EntityReference[] Skills { get; private set; }
        public StatSheet StatSheet { get; private set; }
        public EntityReference DropTable { get; private set; }
        public EntityReference FootStepSound { get; private set; }
        public EntityReference HitSound { get; private set; }
    }
}
