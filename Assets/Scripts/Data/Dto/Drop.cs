using System;
using UnityEngine;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public abstract partial class Drop
    {
        public Type.Drop Type { get; private set; }
        public int Weight { get; private set; }
    }
}
