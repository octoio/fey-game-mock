using System;
using UnityEngine;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public class StatSheet
    {
        public int Vit { get; private set; }
        public int Str { get; private set; }
        public int Int { get; private set; }
        public int Dex { get; private set; }
        public int Armor { get; private set; }
        public int MagicResist { get; private set; }
        public int Health { get; private set; }
        public int Mana { get; private set; }
        public float DamageTakenModifier { get; private set; }
        public float DamageModifier { get; private set; }
        public float MovementSpeed { get; private set; }
        public float MovementSpeedModifier { get; private set; }
        public float AttackSpeed { get; private set; }
        public float AttackPower { get; private set; }
        public float AbilityPower { get; private set; }
        public float CriticalChance { get; private set; }
        public float CriticalDamage { get; private set; }
        public float CooldownReduction { get; private set; }
        public float DodgeChance { get; private set; }
        public float ManaRegen { get; private set; }
        public float HealthRegen { get; private set; }
        public float ExperienceModifier { get; private set; }
        public float GoldModifier { get; private set; }
        public float LifeSteal { get; private set; }
    }
}
