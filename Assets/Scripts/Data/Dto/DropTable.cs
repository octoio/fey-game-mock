using System;
using UnityEngine;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public class DropTable
    {
        public Metadata Metadata { get; private set; }
        public WeightedList<GoldDrop> GoldDrops { get; private set; }
        public WeightedList<EquipmentDrop> EquipmentDrops { get; private set; }
        public WeightedList<WeaponDrop> WeaponDrops { get; private set; }
        public WeightedList<SkillDrop> SkillDrops { get; private set; }
    }
}
