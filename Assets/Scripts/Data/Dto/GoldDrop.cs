using System;
using UnityEngine;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public partial class GoldDrop : Drop
    {
        public IntRange Amount { get; private set; }
    }
}
