using System;
using UnityEngine;

namespace Octoio.Fey.Data.Dto
{
    [Serializable]
    public class Stat
    {
        public Metadata Metadata { get; private set; }
        public Type.Stat Type { get; private set; }
        public Color Color { get; private set; }
    }
}
